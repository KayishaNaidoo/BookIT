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
using Microsoft.VisualBasic;

namespace BookITFinal.Forms
{
    public partial class Account : Form
    {
        String UserIDF;
        DatabaseHelper dbHelper= new DatabaseHelper();
        public Account(string UserID)
        {
            InitializeComponent();
            UserIDF = UserID;
        }

        private void Account_Load(object sender, EventArgs e)
        {
            LoadDetails();  

        }

        private void btnEditFName_Click(object sender, EventArgs e)
        {
            string oldName= lblFName.Text;
            string newName = Interaction.InputBox("Input New First Name", "Edit First Name");


            if (newName == "")
            {
                newName=oldName;
            }

            dbHelper.EditFName(UserIDF, newName);
            LoadDetails();
        }

        private void LoadDetails()
        {
            string[] UserDeets = dbHelper.GetUserDetails(UserIDF);
            lblFName.Text = UserDeets[0];
            lblLName.Text = UserDeets[1];
            lblEmail.Text = UserDeets[2];
            lblContactNo.Text = UserDeets[3];
        }

        private void btnEditLName_Click(object sender, EventArgs e)
        {
            string oldName = lblLName.Text;
            string newName = Interaction.InputBox("Input New Last Name", "Edit Last Name");


            if (newName == "")
            {
                newName = oldName;
            }

            dbHelper.EditLName(UserIDF, newName);
            LoadDetails();
        }
    }
}
