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
using System.Windows.Forms.DataVisualization.Charting;

namespace BookITFinal.Forms
{
    public partial class StudentDashboard : Form
    {
        String UserIDF;
        DatabaseHelper dbHelper = new DatabaseHelper();
        public StudentDashboard(string UserID)
        {
            UserIDF = UserID;
            InitializeComponent();
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            Form CreateB = new CreateBooking(DateTime.Today.AddDays(2), UserIDF);
            CreateB.Show();

        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            

            DataTable bookingsData = dbHelper.GetBookings(UserIDF);
            dgvBookings.DataSource = bookingsData;
            PopulateChart(UserIDF);
           
        }
        public void PopulateChart(string userId)
        {
            cPastBookings.Series.Clear();
            cPastBookings.Titles.Clear();

            DataTable chartData = dbHelper.GetChart(userId);

            Series series = new Series
            {
                Name = "Bookings",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };

            cPastBookings.Series.Add(series);

            series.Font = new Font("Century Gothic", 10, FontStyle.Bold); 
            series.LabelForeColor = Color.White; 
            foreach (DataRow row in chartData.Rows)
            {
                string venueId = row["VenueID"].ToString();
                int count = Convert.ToInt32(row["COUNT(DISTINCT BookingID)"]);

                // Add points to the series
                series.Points.AddXY(venueId, count);
            }

            cPastBookings.Titles.Clear();

            // Create a new title
            Title chartTitle = new Title
            {
                Text = "Bookings Per Venue",
                Font = new Font("Century Gothic", 16, FontStyle.Bold),
                ForeColor = Color.White              
            };

            // Add the title to the chart
            cPastBookings.Titles.Add(chartTitle);

        }



        private void cPastBookings_Click(object sender, EventArgs e)
        {

        }
    }
}
