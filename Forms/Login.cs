using BookITFinal.Colors;
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
    public partial class Login : Form
    {

        bool pass1 = true;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userID= edtRoleNumber.Text;
            String password= edtPassword.Text;
            bool bLogin = false;
            DatabaseHelper dbHelper = new DatabaseHelper();
            bLogin = dbHelper.Login(userID, password);

            if (bLogin==true)
            {
               Form mm = new MainPage(userID);
                mm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User Credentials");
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form WS = new WelcomeScreen();
            WS.Show();
            this.Hide();
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.IconColor = AppColors.AppPurple;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.IconColor = Color.White;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = AppColors.AppPurple;
            btnLogin.IconColor = AppColors.AppPurple;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
            btnLogin.IconColor = Color.White;
 
        }
    }
}
