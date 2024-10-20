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
        String userType;//User type of loggied in User
        DatabaseHelper dbHelper= new DatabaseHelper();
   
        public PopUpCalendar(DateTime date, string userID, string UserType)
        {
            InitializeComponent();
            Date = date;
            UserIDF = userID;
            userType = UserType;
        }

        private void PopUpCalendar_Load(object sender, EventArgs e)
        {
            lblDateInfo.Text = lblDateInfo.Text+ Date.ToString("ddd, dd MMMMM yyyy");
            DataTable bookingsData;
            if (userType == "Admin") 
            {
                bookingsData = dbHelper.GetDayBookingforAll(Date.ToString("yyyy/MM/dd"));
                
            }
            else
            {
                bookingsData = dbHelper.GetDayBookingforUser(UserIDF, Date.ToString("yyyy/MM/dd"));
                if (bookingsData.Rows.Count == 0)
                {
                    bookingsData.Columns.Clear();
                    bookingsData.Columns.Add("Message");


                    DataRow noBookingsRow = bookingsData.NewRow();
                    noBookingsRow["Message"] = "No bookings";


                    bookingsData.Rows.Add(noBookingsRow);
                }

            }
           
            dgvBookings.DataSource = bookingsData;

            if (this.Date <= DateTime.Today.AddDays(2))
            {
                btnCreateBooking.Enabled = false;
                btnCreateBooking.Visible = false;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            if (userType=="Admin")
            {
                Form UserIdSelect = new UserIdSelect();
                UserIdSelect.ShowDialog();
            }
            else
            {
                Form bookingPage = new CreateBooking(this.Date, UserIDF);
                bookingPage.ShowDialog();
            }
            
        }

        private void dgvBookings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvBookings.Rows[e.RowIndex];


                if ((selectedRow.Cells[0].Value != null && selectedRow.Cells[0].Value.ToString().ToUpper() != "No Bookings".ToUpper())&&Date>=DateTime.Today.AddDays(2))
                {
                    var bookingId = selectedRow.Cells[0].Value;

                    Form pop = new popUpBook(bookingId.ToString());
                    pop.ShowDialog();
                    pop.Focus();
                }
               
            }

        }

        private void lblDateInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
