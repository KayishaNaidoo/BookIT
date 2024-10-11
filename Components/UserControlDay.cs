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
        public UserControlDay(DateTime date, string userID)
        {
            InitializeComponent();
            this.date = date;
            this.lblDays.Text = date.Day.ToString() + "";
            UserID = userID;
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {

        }

        private void UserControlDay_Click(object sender, EventArgs e)
        {
            if(this.date>DateTime.Today.AddDays(2)){
            Form bookingPage = new CreateBooking(this.date, UserID);
                bookingPage.ShowDialog();
            }
        }
    }
}
