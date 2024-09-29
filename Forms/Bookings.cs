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
    public partial class Bookings : Form
    {
        String UserIDF;
        public Bookings(String UserID)
        {
            InitializeComponent();
            UserIDF= UserID;
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            Form CreateB = new CreateBooking(DateTime.Today, UserIDF);
            CreateB.Show();
            
        }
    }
}
