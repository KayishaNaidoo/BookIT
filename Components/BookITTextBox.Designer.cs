
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TestingIS.Components
{
    partial class BookITTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TextBox = new TextBox();
            lbl = new Label();
            labelTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.BorderStyle = BorderStyle.None;
            TextBox.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox.Location = new Point(3, 21);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(266, 21);
            TextBox.TabIndex = 0;
            TextBox.TextChanged += TextBox_TextChanged;
            TextBox.Enter += textBox1_Enter;
            TextBox.Leave += textBox1_Leave;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.White;
            lbl.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.Black;
            lbl.Location = new Point(0, 9);
            lbl.Name = "lbl";
            lbl.Size = new Size(45, 22);
            lbl.TabIndex = 1;
            lbl.Text = "Text";
            lbl.Click += label1_Click;
            // 
            // labelTimer
            // 
            labelTimer.Interval = 1;
            labelTimer.Tick += labelTimer_Tick;
            // 
            // BookITTextBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbl);
            Controls.Add(TextBox);
            Name = "BookITTextBox";
            Size = new Size(268, 42);
            Load += BookITTextBox_Load;
            Paint += BookITTextBox_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox;
        private Label lbl;
        private System.Windows.Forms.Timer labelTimer;
    }
}
