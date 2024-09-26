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
       
        public CreateBooking()
        {
            InitializeComponent();
        }

        private void CreateBooking_Load(object sender, EventArgs e)
        {
         
            DatabaseHelper dbHelper = new DatabaseHelper();

            DataTable bookingsData = dbHelper.GetBookings("2562592");
            dgvBookings.DataSource = bookingsData;

       
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
            this.Close();
        }
    }
}
