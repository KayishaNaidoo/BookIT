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
    }
}
