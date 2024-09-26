using BookITFinal.Colors;
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
    public partial class Calendar : Form
    {
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
            displayDays();
        }

        private void displayDays()
        {
            DateTime now= DateTime.Now;

            //first day of month
            DateTime startofM = new DateTime(now.Year, now.Month, 1);
            
            //get num days in month
            int days= DateTime.DaysInMonth(now.Year, now.Month);

            //convert the startofM to int

            int daysofWeek = Convert.ToInt32(startofM.DayOfWeek.ToString("d"));

        }
    }
}
