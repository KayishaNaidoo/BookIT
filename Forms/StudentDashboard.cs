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
    public partial class StudentDashboard : Form
    {
        String UserIDF;
        public StudentDashboard(string UserID)
        {
            UserIDF = UserID;
            InitializeComponent();
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            Form CreateB = new CreateBooking(DateTime.Today, UserIDF);
            CreateB.Show();

        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            DataTable bookingsData = dbHelper.GetBookings(UserIDF);
            dgvBookings.DataSource = bookingsData;
           
        }
    }
}
