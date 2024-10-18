using BookITFinal.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookITFinal.Forms
{
    public partial class CreateBooking : Form
    {
        private DateTime BookingDateF = DateTime.Today;
        private string UserIdF;
        private string bookingDate;

        private DatabaseHelper db = new DatabaseHelper();
        private List<Venue> venueList;
        private List<Venue> filteredVenues = new List<Venue>();
        private List<Booking> bookings;
        private List<string> equipmentList = new List<string>();


        public CreateBooking(DateTime BookingDate, string UserID)
        {
            this.BookingDateF = BookingDate;
            this.UserIdF = UserID;
            InitializeComponent();
        }

        private void CreateBooking_Load(object sender, EventArgs e)
        {

            dtpBookingDate.MinDate = DateTime.Today.AddDays(2);
            dtpBookingDate.Value = BookingDateF;
            dtpBookingDate.Enabled = true;
            this.bookingDate = dtpBookingDate.Value.ToString("HH:mm");
            //@Liam and Colby: This is just a table to play around with queries and it shows it

            string[] startTimes = GenerateStartTimes();
            cbxStartTimes.Items.AddRange(startTimes);

            if (startTimes.Length > 0)
            {
                cbxStartTimes.SelectedIndex = 0;
            }

            venueList = db.GetVenueList();
            bookings = db.getBookingOnDate(this.BookingDateF.ToString("yyyy/MM/dd"));
        }

        // generate start times from 8:00 till 22:00
        private string[] GenerateStartTimes()
        {
            string[] startTimes = new string[12];
            DateTime time = DateTime.Today.AddHours(8);
            for (int i = 0; i < 5; i++)
            {

                startTimes[i] = time.ToString("HH:mm");
                
                if (i % 2 == 1)
                {
                    time = time.AddMinutes(75);
                }
                else
                {
                    time = time.AddHours(1);
                }
            }

            time = time.AddMinutes(45);

            for (int i = 5; i < 12; i++)
            {
                startTimes[i] = time.ToString("HH:mm");

                if (i % 2 == 0)
                {
                    time = time.AddMinutes(75);
                } else
                {
                    time = time.AddHours(1);
                }
            }
            return startTimes.ToArray();
        }

        // Method to generate end times in 45-minute ( + 15 minute breaks) increments from the selected start time
        private string[] GenerateEndTimes(DateTime startTime)
        {
            var endTimes = new System.Collections.Generic.List<string>();
            DateTime maxEndTime = startTime.AddHours(3);//DateTime.Today.AddHours(2);
            DateTime endTime = startTime.AddMinutes(45); 

            while (endTime <= maxEndTime)
            {
                endTimes.Add(endTime.ToString("HH:mm"));
                endTime = endTime.AddMinutes(60);
            }

            return endTimes.ToArray();
        }

        private void cbxStartTimes_SelectedIndexChanged(object sender, EventArgs e)
        {

            //@Liam and Colby: This just recalculates the start times and end times of the combobox when the start time changes

            cbxEndTime.Items.Clear();
            cbxEndTime.Enabled = true;

            string selectedStartTime = cbxStartTimes.SelectedItem.ToString();
            DateTime startTime = DateTime.Parse(selectedStartTime);


            string[] endTimes = GenerateEndTimes(startTime);
            cbxEndTime.Items.AddRange(endTimes);


            if (endTimes.Length > 0)
            {
                cbxEndTime.SelectedIndex = 0;
            }
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string dateOfBooking = dtpBookingDate.Value.ToString("yyyy/MM/dd");
                string eventType = cbxEventType.SelectedItem.ToString();
                string startTime = cbxStartTimes.SelectedItem.ToString();
                string endTime = cbxEndTime.SelectedItem.ToString();
                string venue = filteredVenues[cbxAvailableVenues.SelectedIndex].venueID;

                if (db.createBooking(UserIdF, eventType, venue, dateOfBooking, startTime, endTime))
                {
                    MessageBox.Show("Booking successfully created");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to create booking. Please try again");
                }
            }
        }

        private bool validate()
        {
            if (cbxEventType.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid event type");
                return false;
            }
            if (cbxCapacity.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid capacity selection");
                return false;
            }
            if (cbxStartTimes.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid start time");
                return false;
            }
            if (cbxEndTime.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid end time");
                return false;
            }
            if (cbxAvailableVenues.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid venue selection");
                return false;
            }
            return true;
        }
    


        private void btnSearch_Click(object sender, EventArgs e)
        {
            //@Liam-- Remove this button and change it to make it update on change
            //@Colby & Liam: THis is just to filter the venues to the combobox
            //This only works sometimes for some reason. Keeps saying "Database is closed" when it doesnt work
            //Please do the equipment filtering stuff
            filteredVenues.Clear();

            int max = 0;
            int min = 0;

            switch (cbxCapacity.SelectedIndex)
            {
                case 0:
                    max = 10;
                    min = 2; // 2 - 10
                    break;
                case 1:
                    max = 50;
                    min = 11;// 11 - 50
                    break;
                case 2:
                    max = 100;
                    min = 51;// 51 - 100
                    break;
                case 3:
                    max = 300;
                    min = 101;// 101 - 300
                    break;
                case 4:
                    max = int.MaxValue;
                    min = 301;
                    break;
                default:
                    max = 0;
                    min = 0;
                    break;
            }


            if (cbxStartTimes.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid start time");
                return;
            }
            if (cbxEndTime.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid end time");
                return;
            }

            foreach (Venue venue in venueList)
                {
                    if (venue.capacity >= min && venue.capacity <= max)
                    {
                        if (venue.filter(equipmentList))
                        {
                            bool hasConflict = false;

                            foreach (Booking booking in bookings.Where(b => b.venueId == venue.venueID))
                            {
                                if (booking.isTimeConflict(cbxStartTimes.SelectedItem as string, cbxEndTime.SelectedItem as string))
                                {
                                    hasConflict = true;
                                    break;
                                }
                            }

                            if (!hasConflict)
                            {
                                filteredVenues.Add(venue);
                            }
                        }
                    }
                }

            cbxAvailableVenues.Items.Clear();

            if (filteredVenues != null)
            {
                foreach (Venue filteredVenue in filteredVenues)
                {
                    cbxAvailableVenues.Items.Add(filteredVenue.venueID + " - " + filteredVenue.buildingName);
                }
            }

            cbxAvailableVenues.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cProjector_CheckedChanged(object sender, EventArgs e)
        {
            if (cProjector.Checked) equipmentList.Add("Projector");
            else equipmentList.Remove("Projector");
        }

        private void cMicrophone_CheckedChanged(object sender, EventArgs e)
        {
            if (cMicrophone.Checked) equipmentList.Add("Microphone");
            else equipmentList.Remove("Microphone");
        }

        private void cWhiteboard_CheckedChanged(object sender, EventArgs e)
        {
            if (cWhiteboard.Checked) equipmentList.Add("Whiteboard");
            else equipmentList.Remove("Whiteboard");
        }

        private void cSpeakers_CheckedChanged(object sender, EventArgs e)
        {
            if (cSpeakers.Checked) equipmentList.Add("Speakers");
            else equipmentList.Remove("Speakers");
        }

        private void cCamera_CheckedChanged(object sender, EventArgs e)
        {
            if (cCamera.Checked) equipmentList.Add("Camera");
            else equipmentList.Remove("Camera");
        }

        private void cComputers_CheckedChanged(object sender, EventArgs e)
        {
            if (cComputers.Checked) equipmentList.Add("Computer");
            else equipmentList.Remove("Computer");
        }

        private void cChairs_CheckedChanged(object sender, EventArgs e)
        {
            if (cChairs.Checked)
            {
                equipmentList.Add("Chairs");
                equipmentList.Add("Tables");
            } else
            {
                equipmentList.Remove("Chairs");
                equipmentList.Remove("Tables");
            }
        }

        private void cTelevisions_CheckedChanged(object sender, EventArgs e)
        {
            if (cTelevisions.Checked) equipmentList.Add("Televisions");
            else equipmentList.Remove("Televisions");
        }

        private void cPlugpoints_CheckedChanged(object sender, EventArgs e)
        {
            if (cPlugpoints.Checked) equipmentList.Add("Plugs");
            else equipmentList.Remove("Plugs");
        }

        private void cAircons_CheckedChanged(object sender, EventArgs e)
        {
            if (cAircons.Checked) equipmentList.Add("AirConditioners");
            else equipmentList.Remove("AirConditioners");
        }

        private void dtpBookingDate_ValueChanged(object sender, EventArgs e)
        {
            this.bookingDate = dtpBookingDate.Value.ToString("HH:mm");
            bookings = db.getBookingOnDate(this.bookingDate);
        }
    }
}
