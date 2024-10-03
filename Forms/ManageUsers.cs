using BookITFinal.Components;
using Microsoft.VisualBasic;
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
            string oldEmail = lblLName.Text;
            string newEmail = Interaction.InputBox("Input New Email Address", "Edit Email Address");
            string userID = cbxuserId.SelectedItem.ToString();


            if (newEmail == "")
            {
                newEmail = oldEmail;
            }

            dbHelper.EditEmail(userID, newEmail);
            LoadDetails(userID);

        }

        private void btnEditContactNo_Click(object sender, EventArgs e)
        {

            string oldContact = lblLName.Text;
            string newContact = Interaction.InputBox("Input New Email Address", "Edit Email Address");
            string userID = cbxuserId.SelectedItem.ToString();


            if (newContact == "")
            {
                newContact = oldContact;
            }

            dbHelper.EditContactNo(userID, newContact);
            LoadDetails(userID);
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
    }
}
