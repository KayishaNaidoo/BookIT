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
        DateTime BookingDateF = DateTime.Today;
        string UserIdF;
       
        public CreateBooking(DateTime BookingDate, string UserID)
        {
            BookingDateF = BookingDate;
            UserIdF = UserID;
            InitializeComponent();
        }

        private void CreateBooking_Load(object sender, EventArgs e)
        {

            //@Liam and Colby: This is just a table to play around with queries and it shows it

            dtpBookingDate.Value = BookingDateF;

            string[] startTimes = GenerateStartTimes();
            cbxStartTimes.Items.AddRange(startTimes);

            if (startTimes.Length > 0)
            {
                cbxStartTimes.SelectedIndex = 0;
            }
        }

        // generate start times from 8:00 till 22:00
        private string[] GenerateStartTimes()
        {
            string[] startTimes = new string[14];
            DateTime time = DateTime.Today.AddHours(8); 
            for (int i = 0; i < 14; i++)
            {
                startTimes[i] = time.ToString("HH:mm");
                time = time.AddHours(1);
            }
            return startTimes;
        }

        // Method to generate end times in 1-hour increments from the selected start time
        private string[] GenerateEndTimes(DateTime startTime)
        {
            var endTimes = new System.Collections.Generic.List<string>();
            DateTime maxEndTime = DateTime.Today.AddHours(22);
            DateTime endTime = startTime.AddHours(1); 

            while (endTime <= maxEndTime)
            {
                endTimes.Add(endTime.ToString("HH:mm"));
                endTime = endTime.AddHours(1);
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
            
          //@Liam and Colby: This is just to show the sample data from the form
         

            MessageBox.Show($"User ID: {UserIdF}\n" +
                $"Venue: {cbxAvailableVenues.SelectedIndex} \n" +
                $"Date: {dtpBookingDate.Value} \n" +
                $"Start Time: {cbxStartTimes.SelectedItem} \n" +
                $"End Time: {cbxEndTime.SelectedItem} \n");



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //@Colby & Liam: THis is just to filter the venues to the combobox
            //This only works sometimes for some reason. Keeps saying "Database is closed" when it doesnt work
            //Please do the equipment filtering stuff

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




            DatabaseHelper dbHelper = new DatabaseHelper();
            string[] venues = dbHelper.GetVenues( min, max);
            cbxAvailableVenues.Items.Clear();

            if (venues != null)
            {
                for (int i = 0; i < venues.GetLength(0); i++)
                { 
                    string displayText = $"{venues[i]}"; // "VenueID - BuildingName"
                    cbxAvailableVenues.Items.Add(displayText);
                }
            }
        }
    }
}
