using BookITFinal.Colors;
using BookITFinal.Components;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookITFinal.Forms
{
    public partial class MainPage : Form
    {
        private IconButton currButton;
        private Form currPage;
        private String UserType;
        private String UserIDF;


        // Make rounded edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,      // x upper-left corner
            int nTopRect,       // y upper-left corner
            int nRightRect,     // x lower-right corner
            int nBottomRect,    // y lower-right corner
            int nWidthEllipse,  // height
            int nHeightEllipse  // width
        );
        public MainPage(string userID)
        {
            InitializeComponent();
            //Making rounded Edges
            IntPtr hRgn = CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20);
            this.Region = System.Drawing.Region.FromHrgn(hRgn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            DatabaseHelper dbHelper= new DatabaseHelper();
            UserIDF = userID;
            UserType=dbHelper.GetUserType(userID);
           // MessageBox.Show($"User type is : {UserType}");
            if( UserType == "Admin" ) {
                btnManageUsers.Visible = true;
            }
            
        }

        private void ActivatedButton(object senderBtn)
        {
            DisabledButton(currButton);
            if (senderBtn != null)
            {
                currButton = (IconButton)senderBtn;
                currButton.BackColor = AppColors.navColor;
                lblCurrPage.Text = currButton.Text;

            }
        }

        private void DisabledButton(object senderBtn)
        {
            if (currButton != null)
            {
                currButton.BackColor = AppColors.UIDark;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            ActivatedButton(btnDashboard);
            if (UserType == "Student") { 
                openPage(new StudentDashboard(UserIDF)); }
            
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            ActivatedButton(btnBookings);
            openPage(new Calendar());

        }

        private void btnVenues_Click(object sender, EventArgs e)
        {
            ActivatedButton(btnVenues);
            openPage(new Bookings(UserIDF));
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void iconButton3_Click(object sender, EventArgs e)
        {
            //Account Button code
            ActivatedButton(btnAccount);
            Form signup = new SignUp();
            signup.Show();
            this.Hide();

        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        { 
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Open Curr Page
        private void openPage(Form Page)
        {
            if (currPage != null)
            {
                currPage.Close();
            }
            currPage = Page;
            Page.TopLevel = false;
            currPage.FormBorderStyle = FormBorderStyle.None;
            currPage.Dock = DockStyle.Fill;
            pnlPage.Controls.Add(Page);
            pnlPage.Tag = Page;
            Page.BringToFront();
            Page.Show();


        }

        private void btnSignOut_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnSignOut_MouseLeave(object sender, EventArgs e)
        {
            btnSignOut.ForeColor = Color.White;

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ActivatedButton(btnManageUsers);
            
        }

        private void btnSignOut_MouseEnter(object sender, EventArgs e)
        {
            btnSignOut.ForeColor = AppColors.AppPurple;
        }
    }
}
