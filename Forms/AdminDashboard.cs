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
    public partial class AdminDashboard : Form
    {
        string UserIDF;

        DatabaseHelper dbHelper= new DatabaseHelper();
        public AdminDashboard(string userID)
        {
            InitializeComponent();
            UserIDF = userID;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void cbxUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUserID.SelectedIndex == 0)
            {
                PopulateFullChart();
                DataTable bookingsData = dbHelper.GetAllBookings();
                dgvBookings.DataSource = bookingsData;
            }
            else
            { 
               PopulateChart(cbxUserID.SelectedItem.ToString());
                DataTable bookingsData = dbHelper.GetBookings(cbxUserID.SelectedItem.ToString());
                dgvBookings.DataSource = bookingsData;
            }
        }


        public void PopulateFullChart()
        {
            cPastBookings.Series.Clear();
            cPastBookings.Titles.Clear();

            DataTable chartData = dbHelper.GetAllChart();

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


                series.Points.AddXY(venueId, count);
            }

            cPastBookings.Titles.Clear();


            Title chartTitle = new Title
            {
                Text = $"Top 5 Venues Booked",
                Font = new Font("Century Gothic", 16, FontStyle.Bold),
                ForeColor = Color.White
            };


            cPastBookings.Titles.Add(chartTitle);

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

           
                series.Points.AddXY(venueId, count);
            }

            cPastBookings.Titles.Clear();

        
            Title chartTitle = new Title
            {
                Text = $"{userId}'s Top 5 Venues ",
                Font = new Font("Century Gothic", 16, FontStyle.Bold),
                ForeColor = Color.White
            };

          
            cPastBookings.Titles.Add(chartTitle);

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            string[] userList =dbHelper.GetUserList();
            string CountUsers= dbHelper.CountUsers();
            lblTotalUsers.Text =CountUsers.ToString();

            string CountBookings = dbHelper.CountBookings();
            lblTotalBookings.Text = CountBookings.ToString();

            cbxUserID.Items.Clear();
            cbxUserID.Items.Add("All Bookings");
            cbxUserID.Items.AddRange(userList);
            DataTable bookingsData = dbHelper.GetAllBookings();
            dgvBookings.DataSource = bookingsData;

            //populate all bookings
            PopulateFullChart();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            Form newUser = new AdminSignUp();
            newUser.ShowDialog();

        }

        private void dgvBookings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow selectedRow = dgvBookings.Rows[e.RowIndex];

                // Extract the data from the specific cell, for example, from the first cell
                var bookingId = selectedRow.Cells[0].Value;

                Form pop = new popUpBook(bookingId.ToString());
                pop.ShowDialog();
                pop.Focus();
            }
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            Form CreateB = new CreateBooking(DateTime.Today.AddDays(2), UserIDF);
            CreateB.Show();
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
