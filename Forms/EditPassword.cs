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
    public partial class EditPassword : Form
    {
        string UserIDF;
        public EditPassword(string userID)
        {
            InitializeComponent();
            UserIDF = userID;
        }
        bool pass1 = true;
        bool pass2 = true;

        bool isValid = true;

        private void btnEditPass_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            string NewPass= edtPassword.Text;
            string ConfirmPass=edtRePassword.Text;

            ValidatePassword(NewPass, ConfirmPass);
            if (isValid == true)
            {
                MessageBox.Show("I am Valid");
                db.EditPassword(UserIDF, NewPass);
                this.Close();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
