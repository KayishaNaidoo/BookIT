using BookITFinal.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookITFinal
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //SignUp button
            Form signup= new SignUp();
            signup.Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Form logIn = new Login();
            logIn.Show();
            this.Hide();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form DB = new MainPage("2604668");
            DB.Show();
            this.Hide();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
