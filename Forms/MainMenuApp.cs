using BookITFinal.Colors;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookITFinal.Colors;

namespace BookITFinal.Forms
{
    public partial class MainPage : Form
    {
        private IconButton currButton;
        private Form currPage;

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

        public MainPage()
        {
            InitializeComponent();
            //Making rounded Edges
            IntPtr hRgn = CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20);
            this.Region = System.Drawing.Region.FromHrgn(hRgn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        String UserType;

        private void ActivatedButton(object senderBtn)
        {
            DisabledButton(currButton);
            if (senderBtn != null)
            {
                currButton = (IconButton)senderBtn;
                currButton.BackColor = AppColors.AppPurple;
                iconCurrPage.IconChar = currButton.IconChar;
                lblCurrPage.Text = currButton.Text;

            }
        }

        private void DisabledButton(object senderBtn)
        {
            if (currButton != null)
            {
                currButton.BackColor = AppColors.navColor;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivatedButton(btnDashboard);
            //openPage(new AdminDashboard());
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            ActivatedButton(btnBookings);
            //openPage(new Calendar());
        }

        private void btnVenues_Click(object sender, EventArgs e)
        {
            ActivatedButton(btnVenues);
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void btnAccount_Click(object sender, EventArgs e)
        {
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

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.ForeColor = AppColors.AppPurple;

        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.White;

        }
    }
}
