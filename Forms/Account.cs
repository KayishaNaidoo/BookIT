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
using Microsoft.VisualBasic.ApplicationServices;

namespace BookITFinal.Forms
{
    public partial class Account : Form
    {
        String UserIDF;
        string UserType;
        DatabaseHelper dbHelper= new DatabaseHelper();
        public Account(string UserID)
        {
            InitializeComponent();
            UserIDF = UserID;
            UserType = dbHelper.GetUserType(UserIDF);
        }

        private void Account_Load(object sender, EventArgs e)
        {
            if (UserType == "Admin")
            {
                lblContactAdmin.Visible = false;
                btnEditEmail.Visible = true;
                btnEditContactNo.Visible = true;
            }
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

        private void tblpAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditEmail_Click(object sender, EventArgs e)
        {
            string oldEmail = lblLName.Text;
            string newEmail = Interaction.InputBox("Input New Email Address", "Edit Email Address");


            if (newEmail == "")
            {
                newEmail = oldEmail;
            }

            dbHelper.EditEmail(UserIDF, newEmail);
            LoadDetails();

        }

        private void btnEditContactNo_Click(object sender, EventArgs e)
        {

            string oldContact = lblLName.Text;
            string newContact = Interaction.InputBox("Input New Email Address", "Edit Email Address");


            if (newContact == "")
            {
                newContact = oldContact;
            }

            dbHelper.EditContactNo(UserIDF, newContact);
            LoadDetails();
        }
    }
}
