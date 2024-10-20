using BookITFinal.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookITFinal.Components
{
    public partial class UserControlDay : UserControl
    {

        private DateTime date;
        private string UserID;

        DatabaseHelper dbHelper= new DatabaseHelper();
        public UserControlDay(DateTime date, string userID)
        {
            InitializeComponent();
            this.date = date;
            this.lblDays.Text = date.Day.ToString();
            UserID = userID;
        }



        private void UserControlDay_Load(object sender, EventArgs e)
        {

            DataTable bookingsData = dbHelper.GetDayBookingforUser(UserID, date.ToString("yyyy/MM/dd"));
            if (bookingsData.Rows.Count == 0)
            {
                iBookings.Visible = false;
            }
            else
            {
                iBookings.Visible = true;
                if (this.date < DateTime.Today)
                {
                    iBookings.IconColor = Color.Crimson;
                }
                else
                {
                    iBookings.IconColor = Color.Chartreuse;
                }
            }

            

        }

        private void UserControlDay_Click(object sender, EventArgs e)
        {
            string UserType = dbHelper.GetUserType(UserID);
            Form ViewDayBookings = new PopUpCalendar(date, UserID, UserType);
            ViewDayBookings.ShowDialog();
        }
    }
}
