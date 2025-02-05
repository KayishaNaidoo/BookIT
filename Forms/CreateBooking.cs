﻿using BookITFinal.Components;
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
            this.BookingDateF = BookingDate;
            this.UserIdF = UserID;
            InitializeComponent();
        }

        private void CreateBooking_Load(object sender, EventArgs e)
        {

            dtpBookingDate.MinDate = DateTime.Today.AddDays(2);
            dtpBookingDate.Value = BookingDateF;
            //@Liam and Colby: This is just a table to play around with queries and it shows it

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

            //@Liam and Colby: This is just to show the sample data from the form

            if (validate())
            {
                string dateOfBooking = dtpBookingDate.Value.ToString("yyyy-MM-dd");
                string eventType = cbxEventType.SelectedItem.ToString();
                string startTime = cbxStartTimes.SelectedItem.ToString();
                string endTime = cbxEndTime.SelectedItem.ToString();
                string venue = cbxAvailableVenues.SelectedItem.ToString().Split('-')[0].Trim();
                DatabaseHelper db = new DatabaseHelper();

                /*MessageBox.Show($"User ID: {UserIdF}\n" +
                    $"Venue: {cbxAvailableVenues.SelectedIndex} \n" +
                    $"Date: {dtpBookingDate.Value} \n" +
                    $"Start Time: {cbxStartTimes.SelectedItem} \n" +
                    $"End Time: {cbxEndTime.SelectedItem} \n");*/
                if (db.createBooking(UserIdF, eventType, venue, dateOfBooking, startTime, endTime))
                {
                    MessageBox.Show("Booking successfully created");
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

            cbxAvailableVenues.Enabled=true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
