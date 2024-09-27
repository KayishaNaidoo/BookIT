using BookITFinal.Colors;
using BookITFinal.Components;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookITFinal.Forms
{
    public partial class Calendar : Form
    {

        private DateTime currentDate;
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnPrev_MouseEnter(object sender, EventArgs e)
        {
            btnPrev.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPrev.IconColor = AppColors.navColor;
        }

        private void btnPrev_MouseLeave(object sender, EventArgs e)
        {

            btnPrev.IconColor = Color.White;
        }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.IconColor = AppColors.navColor;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.IconColor = Color.White;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            currentDate = DateTime.Now;
            lblMonthYear.Text = currentDate.ToString("MMMM yyyy");

            displayDays();
            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1); // Decrease the current month by 1
            displayDays(); // Redisplay the days for the new month
        }

        // Event handler for the "Next" button click (move to the next month)
        private void btnNext_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1); // Increase the current month by 1
            displayDays(); // Redisplay the days for the new month
        }

        // Method to display the days in the current month
        private void displayDays()
        {

            lblMonthYear.Text = currentDate.ToString("MMMM yyyy");
            // Clear the previously displayed days
            flpDays.Controls.Clear();

            // Get the first day of the month
            DateTime startofM = new DateTime(currentDate.Year, currentDate.Month, 1);

            // Get the number of days in the current month
            int days = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

            // Convert the first day of the month to an int representing the day of the week (0 = Sunday, 6 = Saturday)
            int daysofWeek = Convert.ToInt32(startofM.DayOfWeek.ToString("d"));

            // Add blank controls for the days before the first day of the month
            for (int i = 0; i < daysofWeek; i++)
            {
                UserControlBlank calenderDay = new UserControlBlank();
                flpDays.Controls.Add(calenderDay);
            }

            // Add controls for each day of the month
            for (int i = 1; i <= days; i++)
            {
                UserControlDay ucDay = new UserControlDay();
                ucDay.days(i);  // Set the day number
                flpDays.Controls.Add(ucDay);
            }
        }

            private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
