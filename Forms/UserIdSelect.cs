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
    public partial class UserIdSelect : Form
    {
        DatabaseHelper dbHelper= new DatabaseHelper();
        public UserIdSelect()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserIdSelect_Load(object sender, EventArgs e)
        {
            string[] userList = dbHelper.GetUserList();
            cbxUserID.Items.Clear();
            cbxUserID.Items.AddRange(userList);

            cbxUserID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxUserID.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (cbxUserID.SelectedIndex >= 0)
            {
                Form CreateBooking = new CreateBooking(DateTime.Today.AddDays(2), cbxUserID.SelectedItem.ToString());
                this.Close();
                CreateBooking.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a valid UserID");
            }
           
        }
    }
}
