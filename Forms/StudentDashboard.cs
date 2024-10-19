using BookITFinal.Colors;
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
            lblBookings.Text = dbHelper.GetTotalBookingUser(UserIDF);
            DataTable bookingsData = dbHelper.GetBookings(UserIDF);
            dgvBookings.DataSource = bookingsData;
            PopulateChart(UserIDF);
           
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
                    IsValueShownAsLabel = false,
                    ChartType = SeriesChartType.Pie 
                };

               
                messageSeries.Points.AddXY("No Bookings", 1); 

                cPastBookings.Series.Add(messageSeries);

             
                Title messageTitle = new Title
                {
                    Text = "NO BOOKINGS MADE",
                    ForeColor = Color.White,
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



        private void cPastBookings_Click(object sender, EventArgs e)
        {

        }

        private void dgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
                
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable bookingsData = dbHelper.GetBookings(UserIDF);
            dgvBookings.DataSource = bookingsData;
            PopulateChart(UserIDF);
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.IconColor = AppColors.AppPurple;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.IconColor = Color.White;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
