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
    public partial class UpdateBooking : Form
    {
        string BookingID;
        public UpdateBooking(string BID)
        {
            InitializeComponent();
            BookingID = BID;
        }

        private void UpdateBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
