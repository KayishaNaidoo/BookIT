using BookITFinal.Components;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookITFinal.Forms
{
    public partial class ManageUsers : Form
    { 
        DatabaseHelper dbHelper= new DatabaseHelper();
        string UserType;
        public ManageUsers()
        {
            InitializeComponent();
            
        }


        private void ManageUsers_Load(object sender, EventArgs e)
        {

            string[] userList = dbHelper.GetUserList();
            cbxuserId.Items.Clear();
            cbxuserId.Items.AddRange(userList);
            cbxuserId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;  
            cbxuserId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxuserId.SelectedIndex = 0;

        }

        private void btnEditFName_Click(object sender, EventArgs e)
        {
            string oldName = lblFName.Text;
            string newName = Interaction.InputBox("Input New First Name", "Edit First Name");
            string userID = cbxuserId.SelectedItem.ToString();

            if (newName == "")
            {
                newName = oldName;
            }

            dbHelper.EditFName(userID, newName);
            LoadDetails(userID);
        }

        private void LoadDetails(string userID)
        {
            lblRole.Text= dbHelper.GetUserType(userID);
            string[] UserDeets = dbHelper.GetUserDetails(userID);
            lblFName.Text = UserDeets[0];
            lblLName.Text = UserDeets[1];
            lblEmail.Text = UserDeets[2];
            lblContactNo.Text = UserDeets[3];
        }

        private void btnEditLName_Click(object sender, EventArgs e)
        {
            string oldName = lblLName.Text;
            string newName = Interaction.InputBox("Input New Last Name", "Edit Last Name");
            string userID = cbxuserId.SelectedItem.ToString();


            if (newName == "")
            {
                newName = oldName;
            }

            dbHelper.EditLName(userID, newName);
            LoadDetails(userID);
        }

        private void tblpAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditEmail_Click(object sender, EventArgs e)
        {
            string oldEmail = lblEmail.Text;
            string newEmail = Interaction.InputBox("Input New Email Address", "Edit Email Address");
            string userID = cbxuserId.SelectedItem.ToString();

            string EditUserType= dbHelper.GetUserType(userID);

            bool isValidEmail= ValidateEmail(newEmail, EditUserType);

            if (isValidEmail==true) {
                dbHelper.EditEmail(userID, newEmail);
                LoadDetails(userID);
            }

        }

        private void btnEditContactNo_Click(object sender, EventArgs e)
        {

            string oldContact = lblContactNo.Text;
            string newContact = Interaction.InputBox("Input New Contact Number", "Edit Contact Number");
            string userID = cbxuserId.SelectedItem.ToString();

            bool isValidContact = ValidateContactNo(newContact);

            if(isValidContact==true){
                dbHelper.EditContactNo(userID, newContact);
                LoadDetails(userID);
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

        bool ValidateEmail(String EmailAddress,string userType)
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

            if (userType == "Student")
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




        private void cbxuserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDetails(cbxuserId.SelectedItem.ToString());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {  
            
            dbHelper.DeletUser(cbxuserId.SelectedItem.ToString());

            //reload user array
            string[] userList = dbHelper.GetUserList();
            cbxuserId.Items.Clear();
            cbxuserId.Items.AddRange(userList);

            //go to first item
            cbxuserId.SelectedIndex = 0;
            LoadDetails(cbxuserId.Items[0].ToString());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
