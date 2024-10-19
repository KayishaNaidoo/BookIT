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

            if (cbxUserID.SelectedIndex > 0)
                btnCreateBooking.Text = $"CREATE BOOKING FOR {cbxUserID.SelectedItem as string}";
            else
                btnCreateBooking.Text = "CREATE BOOKING FOR USER";
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

            if (chartData == null || chartData.Rows.Count == 0)
            {
              
                Series messageSeries = new Series
                {
                    Name = "NoBookings",
                    IsValueShownAsLabel = false, // Do not show labels
                    ChartType = SeriesChartType.Pie // Use Pie type for consistency
                };

                messageSeries.Points.AddXY("No Bookings", 1); // Add a dummy point

               
                cPastBookings.Series.Add(messageSeries);

             
                Title messageTitle = new Title
                {
                    Text = "NO BOOKINGS MADE",
                    Font = new Font("Century Gothic", 16, FontStyle.Bold),
                    Alignment = ContentAlignment.MiddleCenter 
                };

                
                cPastBookings.Titles.Add(messageTitle);

                cPastBookings.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
                cPastBookings.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;

               
                cPastBookings.Invalidate();
                return; 
            }

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

            Title chartTitle = new Title
            {
                Text = $"{userId}'s Top 5 Venues ",
                Font = new Font("Century Gothic", 16, FontStyle.Bold),
                ForeColor = Color.White
            };

            cPastBookings.Titles.Add(chartTitle);
            cPastBookings.Invalidate();
        }


        private void AdminDashboard_Load(object sender, EventArgs e)
        {

            string[] userList = dbHelper.GetUserList();
            string CountUsers = dbHelper.CountUsers();
            lblTotalUsers.Text = CountUsers.ToString();

            string CountBookings = dbHelper.CountBookings();
            lblTotalBookings.Text = CountBookings.ToString();

            cbxUserID.Items.Clear();
            cbxUserID.Items.Add("All Bookings");
            cbxUserID.SelectedIndex = 0;
            cbxUserID.Items.AddRange(userList);
            DataTable bookingsData = dbHelper.GetAllBookings();
            dgvBookings.DataSource = bookingsData;

            cbxUserID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxUserID.AutoCompleteSource = AutoCompleteSource.ListItems;

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
                DataGridViewRow selectedRow = dgvBookings.Rows[e.RowIndex];

                var bookingId = selectedRow.Cells[0].Value;

                Form pop = new popUpBook(bookingId.ToString());
                pop.ShowDialog();
                pop.Focus();
            }
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            if (cbxUserID.SelectedIndex > 0)
            {
                Form CreateB = new CreateBooking(DateTime.Today.AddDays(2), cbxUserID.SelectedItem as string);
                CreateB.Show();
            } else
            {
                Form SelectUser = new UserIdSelect();
                SelectUser.ShowDialog();
            }
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (cbxUserID.SelectedIndex <= 0)
            {
                PopulateFullChart();
                DataTable bookingsData = dbHelper.GetAllBookings();
                dgvBookings.DataSource = bookingsData;
                //btnCreateBooking.Enabled = false;
            }
            else
            {
                PopulateChart(cbxUserID.SelectedItem.ToString());
                DataTable bookingsData = dbHelper.GetBookings(cbxUserID.SelectedItem.ToString());
                dgvBookings.DataSource = bookingsData;
                
            }
        }
    }
}
