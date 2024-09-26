using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookITFinal.Colors;

namespace TestingIS.Components
{
    public partial class BookITTextBox : UserControl
    {
        public BookITTextBox()
        {
            InitializeComponent();
        }
        bool isFocused = false;
        private string text = "label";
        private bool pass = false;

        public string customText
        {
            get { return text; }
            set
            {
                text = value;
                this.Invalidate();
            }
        }


        private void BookITTextBox_Load(object sender, EventArgs e)
        {
            if (password == true)
            {
                TextBox.UseSystemPasswordChar = true;
            }

        }

        public bool password
        {
            get { return pass; }
            set
            {
                pass = value;
                this.Invalidate();
            }
        }
        private void BookITTextBox_Paint(object sender, PaintEventArgs e)
        {
            lbl.Text = customText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelTimer_Tick(object sender, EventArgs e)
        {
            int y = lbl.Location.Y;
            isFocused = TextBox.Focused;
            if (isFocused == true)
            {
                y -= 2;
                lbl.Location = new Point(lbl.Location.X, y);
                if (y <= 2)
                {
                    isFocused = true;
                    labelTimer.Stop();
                    lbl.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                    y = 0;
                    lbl.ForeColor = Color.Black;

                }
            }
            else
            {
                y += 2;
                lbl.Location = new Point(lbl.Location.X, y);
                if (y >= 9)
                {
                    isFocused = true;
                    labelTimer.Stop();
                    lbl.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                    y = 9;
                    lbl.ForeColor = Color.Black;


                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (TextBox.Text == "")
            {
                labelTimer.Start();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (TextBox.Text == "")
            {
                labelTimer.Start();
            }
        }

        public string Tbxtext;
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Tbxtext= TextBox.Text;
        }
    }
}
