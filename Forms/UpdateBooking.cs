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
    public partial class UpdateBooking : Form
    {
        string BookingID;

        private DatabaseHelper db = new DatabaseHelper();
        private List<Venue> venueList;
        private List<Venue> filteredVenues = new List<Venue>();
        private List<Booking> bookings;
        private List<string> equipmentList = new List<string>();

        public UpdateBooking(string BID)
        {
            InitializeComponent();
            BookingID = BID;
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
            if (cbxAvailableVenues.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid venue selection");
                return false;
            }
            return true;
        }

        private void UpdateBooking_Load(object sender, EventArgs e)
        {
            Booking booking = db.GetBooking(BookingID);
            dtpBookingDate.Value = DateTime.Parse(booking.date);
            cbxEventType.Items.Add(booking.eventType);
            cbxEventType.SelectedIndex = 0;
            cbxStartTimes.Items.Add(booking.startTime);
            cbxStartTimes.SelectedIndex = 0;
            cbxEndTime.Items.Add(booking.endTime);
            cbxEndTime.SelectedIndex = 0;

            venueList = db.GetVenueList();
            bookings = db.getBookingOnDate(booking.date);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string venue = filteredVenues[cbxAvailableVenues.SelectedIndex].venueID;

                if (db.updateBooking(BookingID, venue))
                {
                    MessageBox.Show("Booking updated succesffully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to create booking. Please try again");
                }
            }
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
            }
            else
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
    }
}
