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
    public partial class popUpBook : Form
    {
        string BID;

        DatabaseHelper dbHelper= new DatabaseHelper();
        public popUpBook(string BookingID)
        {
            InitializeComponent();
            BID = BookingID;
        }

        private void popUpBook_Load(object sender, EventArgs e)
        {
            lblBookingID.Text=$"Booking ID: {BID}";
            this.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelB_Click(object sender, EventArgs e)
        {
            dbHelper.DeleteBooking(BID);
            this.Close();
        }

        private void btnUpdateB_Click(object sender, EventArgs e)
        {
            Form bUpdate = new UpdateBooking(BID);
            bUpdate.ShowDialog();
            this.Close();
        }
    }
}
