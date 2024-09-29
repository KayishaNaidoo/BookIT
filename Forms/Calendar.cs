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
            btnPrev.IconColor = AppColors.AppPurple;
        }

        private void btnPrev_MouseLeave(object sender, EventArgs e)
        {

            btnPrev.IconColor = Color.White;
        }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.IconColor = AppColors.AppPurple;
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
            currentDate = currentDate.AddMonths(-1);
            displayDays(); 
        }

      
        private void btnNext_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            displayDays(); 
        }

 
        private void displayDays()
        {

            lblMonthYear.Text = currentDate.ToString("MMMM yyyy");
    
            flpDays.Controls.Clear();

            DateTime startofM = new DateTime(currentDate.Year, currentDate.Month, 1);

          
            int days = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

         
            int daysofWeek = Convert.ToInt32(startofM.DayOfWeek.ToString("d"));

          
            for (int i = 0; i < daysofWeek; i++)
            {
                UserControlBlank calenderDay = new UserControlBlank();
                flpDays.Controls.Add(calenderDay);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDay ucDay = new UserControlDay();
                ucDay.days(i); 
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
