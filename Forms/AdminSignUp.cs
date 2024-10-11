using BookITFinal.Components;
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
    public partial class AdminSignUp : Form
    {
        
        public AdminSignUp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool pass1 = true;
        bool pass2 = true;

        bool isValid = true;


        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            String FName;
            String LName;
            String EmailAddress;
            String Password;
            String RePassword;
            String RoleNumber;
            String ContactNo;

            // Get all the user input
            FName = edtFirstName.Tbxtext;
            LName = edtLastName.Tbxtext;
            RoleNumber = edtRoleNum.Tbxtext;
            EmailAddress = edtEmail.Tbxtext;
            ContactNo = edtPhoneNo.Tbxtext;
            Password = edtPassword.Text;
            RePassword = edtRePassword.Text;


      
            isValid = true;

    
            ValidateFName(FName);
            if (!isValid) return;

            ValidateLName(LName);
            if (!isValid) return;

            ValidateRoleNumber(RoleNumber);
            if (!isValid) return;

            ValidateEmail(EmailAddress);
            if (!isValid) return;

            ValidateContactNo(ContactNo);
            if (!isValid) return;

            ValidatePassword(Password, RePassword);
            if (!isValid) return;

            if (isValid)
            {
                MessageBox.Show("Registration successful!");
                DatabaseHelper dbHelp = new DatabaseHelper();
                dbHelp.CreateUser(RoleNumber, FName, LName, EmailAddress, ContactNo, Password, cbxRole.Text);
                this.Close();
            }
        }

        private void ValidateFName(String FName)
        {
            if (string.IsNullOrEmpty(FName))
            {
                MessageBox.Show("First name cannot be empty!");
                isValid = false;
                return;
            }
        }

        private void ValidateLName(String LName)
        {
            if (string.IsNullOrEmpty(LName))
            {
                MessageBox.Show("Last name cannot be empty!");
                isValid = false;
                return;
            }
        }

        private void ValidateEmail(String EmailAddress)
        {

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrEmpty(EmailAddress))
            {
                MessageBox.Show("Email address cannot be empty!");
                isValid = false;
                return;
            }


            bool isValidEmailFormat = Regex.IsMatch(EmailAddress, emailPattern);

            if (!isValidEmailFormat)
            {
                MessageBox.Show("Invalid email address format!");
                isValid = false;
                return;
            }

            if (cbxRole.SelectedIndex == 1)
            {
                if (!EmailAddress.EndsWith("@students.wits.ac.za"))
                {
                    MessageBox.Show("Student email must end with @students.wits.ac.za");
                    isValid = false;
                    return;
                }
            }
            else  // Employee role
            {
                if (!EmailAddress.EndsWith("@wits.ac.za"))
                {
                    MessageBox.Show("Employee email must end with @wits.ac.za");
                    isValid = false;
                    return;
                }
            }

            isValid = true;
        }


        private void ValidateRoleNumber(String RoleNumber)
        {
            bool isEmpty = string.IsNullOrEmpty(RoleNumber);



            if (isEmpty)
            {
                MessageBox.Show("Student Number/Employee Number must not be empty.");
                isValid = false;
                return;
            }

            bool isNumeric = RoleNumber.All(char.IsDigit);

            if (!isNumeric)
            {
                MessageBox.Show("Role number must contain only numeric characters!");
                isValid = false;
                return;
            }
        }

        private void ValidateContactNo(String ContactNo)
        {
            bool isEmpty = string.IsNullOrEmpty(ContactNo);

            if (isEmpty)
            {
                MessageBox.Show("Phone Number must not be empty.");
                isValid = false;
                return;
            }

            bool bLength = ContactNo.Length == 10 ? true : false;
            bool isNumeric = ContactNo.All(char.IsDigit);


            if (!isNumeric || !bLength)
            {
                MessageBox.Show("Phone Number must be 10 digits");
                isValid = false;
                return;
            }
        }

        private void ValidatePassword(String Password, String RePassword)
        {
            // Password validation: minimum 5 chars, 1 special char, 1 uppercase, 1 number
            bool hasUpperCase = Password.Any(char.IsUpper);
            bool hasLowerCase = Password.Any(char.IsLower);
            bool hasDigit = Password.Any(char.IsDigit);
            bool hasSpecialChar = Password.Any(ch => !char.IsLetterOrDigit(ch));
            bool hasMinLength = Password.Length >= 5;

            if (!(hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar && hasMinLength))
            {
                StringBuilder errorMessage = new StringBuilder("Password must meet the following requirements:\n");
                if (!hasUpperCase) errorMessage.AppendLine("- At least one uppercase letter");
                if (!hasLowerCase) errorMessage.AppendLine("- At least one lowercase letter");
                if (!hasDigit) errorMessage.AppendLine("- At least one number");
                if (!hasSpecialChar) errorMessage.AppendLine("- At least one special character");
                if (!hasMinLength) errorMessage.AppendLine("- At least 5 characters long");

                MessageBox.Show(errorMessage.ToString());
                isValid = false;
                return;
            }

            // passwords musr match
            if (Password != RePassword)
            {
                MessageBox.Show("Passwords do not match!");
                isValid = false;
            }
        }

        private void cbxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRole.SelectedIndex == 1)
            {
                edtRoleNum.customText = "Student Number:";
                iconRole.IconChar = FontAwesome.Sharp.IconChar.Glasses;
                iconRoleNum.IconChar = FontAwesome.Sharp.IconChar.Glasses;

            }
            else if(cbxRole.SelectedIndex==0)
            {
                edtRoleNum.customText = "Employee Number:";
                iconRole.IconChar = FontAwesome.Sharp.IconChar.Bell;
                iconRoleNum.IconChar = FontAwesome.Sharp.IconChar.Bell;
            }
            else if (cbxRole.SelectedIndex == 2)
            {
                edtRoleNum.customText = "Employee Number:";
                iconRole.IconChar = FontAwesome.Sharp.IconChar.Chalkboard;
                iconRoleNum.IconChar = FontAwesome.Sharp.IconChar.Chalkboard;
            }
        }

        private void iconEyePass_Click(object sender, EventArgs e)
        {
            pass1 = !pass1;

            if (pass1)
            {
                edtPassword.PasswordChar = '#';
                iconEyePass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else
            {
                edtPassword.PasswordChar = '\0';
                iconEyePass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }

        private void iconEyeRePas_Click(object sender, EventArgs e)
        {
            pass2 = !pass2; 

            if (pass2)
            {
                edtRePassword.PasswordChar = '#';
                iconEyeRePas.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else
            {
                edtRePassword.PasswordChar = '\0';
                iconEyeRePas.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
