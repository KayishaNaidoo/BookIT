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
    public partial class PopUpCalendar : Form
    {
        DateTime Date;
        String UserIDF;
        DatabaseHelper dbHelper= new DatabaseHelper();
   
        public PopUpCalendar(DateTime date, string userID)
        {
            InitializeComponent();
            Date = date;
            UserIDF = userID;
        }

        private void PopUpCalendar_Load(object sender, EventArgs e)
        {
            lblDateInfo.Text = lblDateInfo.Text+ Date.ToString("ddd, dd MMMMM yyyy");
            DataTable bookingsData = dbHelper.GetDayBookingforUser(UserIDF,Date.ToString("yyyy/MM/dd"));
            dgvBookings.DataSource = bookingsData;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            if (this.Date > DateTime.Today.AddDays(2))
            {
                Form bookingPage = new CreateBooking(this.Date, UserIDF);
                bookingPage.ShowDialog();
            }
            else
            {
                Form bookingPage = new CreateBooking(DateTime.Today.AddDays(2), UserIDF);
                bookingPage.ShowDialog();
            }
        }
    }
}
