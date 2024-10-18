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
using System.Text.RegularExpressions;

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
            lblRole.Text = UserType;
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
            string oldEmail = lblEmail.Text;
            string newEmail = Interaction.InputBox("Input New Email Address", "Edit Email Address");



            bool isValidEmail = ValidateEmail(newEmail);
            if (isValidEmail == true)
            {

                dbHelper.EditEmail(UserIDF, newEmail);
                LoadDetails();
            }

        }

        private void btnEditContactNo_Click(object sender, EventArgs e)
        {

            string oldContact = lblLName.Text;
            string newContact = Interaction.InputBox("Input New Contact Number", "Edit Contact Number");


                bool isValidContact = ValidateContactNo(newContact);
                if (isValidContact == true)
                {
                    dbHelper.EditContactNo(UserIDF, newContact);
                    LoadDetails();
                }
        }

        bool ValidateContactNo(String ContactNo)
        {
            bool isEmpty = string.IsNullOrEmpty(ContactNo);

            if (isEmpty)
            {
                MessageBox.Show("Phone Number must not be empty.");
                return false;
               
            }

            bool bLength = ContactNo.Length == 10 ? true : false;
            bool isNumeric = ContactNo.All(char.IsDigit);


            if (!isNumeric || !bLength)
            {
                MessageBox.Show("Phone Number must be 10 digits");
                return false;
             
            }

            return true;
        }

        bool ValidateEmail(String EmailAddress)
        {

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrEmpty(EmailAddress))
            {
                MessageBox.Show("Email address cannot be empty!");
                return false;
               
            }


            bool isValidEmailFormat = Regex.IsMatch(EmailAddress, emailPattern);

            if (!isValidEmailFormat)
            {
                MessageBox.Show("Invalid email address format!");
                return false;
                
            }

            if (UserType=="Student")
            {
                if (!EmailAddress.EndsWith("@students.wits.ac.za"))
                {
                    MessageBox.Show("Student email must end with @students.wits.ac.za");
                    return false;
                   
                }
            }
            else 
            {
                if (!EmailAddress.EndsWith("@wits.ac.za"))
                {
                    MessageBox.Show("Employee email must end with @wits.ac.za");
                    return false;
                   
                }
            }

           return true;
        }


        private void btnEditPass_Click(object sender, EventArgs e)
        {
            Form EditPass = new EditPassword(UserIDF);
            EditPass.ShowDialog();
        }
    }
}
