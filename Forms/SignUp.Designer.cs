﻿namespace BookITFinal.Forms
{
    partial class SignUp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.edtPassword = new System.Windows.Forms.TextBox();
            this.edtRePassword = new System.Windows.Forms.TextBox();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.iconRole = new FontAwesome.Sharp.IconPictureBox();
            this.iconRoleNum = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconEyeRePas = new FontAwesome.Sharp.IconPictureBox();
            this.iconEyePass = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlFields = new System.Windows.Forms.Panel();
            this.edtFirstName = new TestingIS.Components.BookITTextBox();
            this.edtLastName = new TestingIS.Components.BookITTextBox();
            this.edtRoleNum = new TestingIS.Components.BookITTextBox();
            this.edtEmail = new TestingIS.Components.BookITTextBox();
            this.edtPhoneNo = new TestingIS.Components.BookITTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRoleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyeRePas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyePass)).BeginInit();
            this.pnlFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 137);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnBack.IconColor = System.Drawing.Color.White;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnBack.Location = new System.Drawing.Point(26, 51);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 48);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnSignUp.IconColor = System.Drawing.Color.White;
            this.btnSignUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignUp.Location = new System.Drawing.Point(132, 10);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(234, 78);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Create Account";
            this.btnSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            this.btnSignUp.MouseEnter += new System.EventHandler(this.btnSignUp_MouseEnter);
            this.btnSignUp.MouseLeave += new System.EventHandler(this.btnSignUp_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSignUp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 759);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 100);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(52, 44);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(52, 111);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 9;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // edtPassword
            // 
            this.edtPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPassword.Location = new System.Drawing.Point(102, 484);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.PasswordChar = '#';
            this.edtPassword.Size = new System.Drawing.Size(297, 30);
            this.edtPassword.TabIndex = 6;
            this.edtPassword.TextChanged += new System.EventHandler(this.edtPassword_TextChanged);
            // 
            // edtRePassword
            // 
            this.edtRePassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtRePassword.Location = new System.Drawing.Point(102, 549);
            this.edtRePassword.Name = "edtRePassword";
            this.edtRePassword.PasswordChar = '#';
            this.edtRePassword.Size = new System.Drawing.Size(297, 30);
            this.edtRePassword.TabIndex = 7;
            this.edtRePassword.TextChanged += new System.EventHandler(this.edtRePassword_TextChanged);
            // 
            // cbxRole
            // 
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRole.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Items.AddRange(new object[] {
            "Student",
            "Lecturer"});
            this.cbxRole.Location = new System.Drawing.Point(102, 200);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(335, 29);
            this.cbxRole.TabIndex = 2;
            this.cbxRole.SelectedIndexChanged += new System.EventHandler(this.cbxRole_SelectedIndexChanged);
            // 
            // iconRole
            // 
            this.iconRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.iconRole.IconChar = FontAwesome.Sharp.IconChar.Glasses;
            this.iconRole.IconColor = System.Drawing.Color.White;
            this.iconRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRole.Location = new System.Drawing.Point(52, 200);
            this.iconRole.Name = "iconRole";
            this.iconRole.Size = new System.Drawing.Size(32, 32);
            this.iconRole.TabIndex = 13;
            this.iconRole.TabStop = false;
            this.iconRole.Click += new System.EventHandler(this.iconRole_Click);
            // 
            // iconRoleNum
            // 
            this.iconRoleNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.iconRoleNum.IconChar = FontAwesome.Sharp.IconChar.Glasses;
            this.iconRoleNum.IconColor = System.Drawing.Color.White;
            this.iconRoleNum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRoleNum.Location = new System.Drawing.Point(52, 260);
            this.iconRoleNum.Name = "iconRoleNum";
            this.iconRoleNum.Size = new System.Drawing.Size(32, 32);
            this.iconRoleNum.TabIndex = 14;
            this.iconRoleNum.TabStop = false;
            this.iconRoleNum.Click += new System.EventHandler(this.iconRoleNum_Click);
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpenText;
            this.iconPictureBox5.IconColor = System.Drawing.Color.White;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.Location = new System.Drawing.Point(52, 398);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox5.TabIndex = 15;
            this.iconPictureBox5.TabStop = false;
            this.iconPictureBox5.Click += new System.EventHandler(this.iconPictureBox5_Click);
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox6.IconColor = System.Drawing.Color.White;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.Location = new System.Drawing.Point(52, 482);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox6.TabIndex = 16;
            this.iconPictureBox6.TabStop = false;
            this.iconPictureBox6.Click += new System.EventHandler(this.iconPictureBox6_Click);
            // 
            // iconPictureBox7
            // 
            this.iconPictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconPictureBox7.IconColor = System.Drawing.Color.White;
            this.iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox7.Location = new System.Drawing.Point(52, 328);
            this.iconPictureBox7.Name = "iconPictureBox7";
            this.iconPictureBox7.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox7.TabIndex = 19;
            this.iconPictureBox7.TabStop = false;
            this.iconPictureBox7.Click += new System.EventHandler(this.iconPictureBox7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "I am a:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(52, 549);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 21;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // iconEyeRePas
            // 
            this.iconEyeRePas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.iconEyeRePas.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconEyeRePas.IconColor = System.Drawing.Color.White;
            this.iconEyeRePas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEyeRePas.Location = new System.Drawing.Point(405, 549);
            this.iconEyeRePas.Name = "iconEyeRePas";
            this.iconEyeRePas.Size = new System.Drawing.Size(32, 32);
            this.iconEyeRePas.TabIndex = 23;
            this.iconEyeRePas.TabStop = false;
            this.iconEyeRePas.Click += new System.EventHandler(this.iconEyeRePas_Click);
            // 
            // iconEyePass
            // 
            this.iconEyePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.iconEyePass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconEyePass.IconColor = System.Drawing.Color.White;
            this.iconEyePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEyePass.Location = new System.Drawing.Point(405, 482);
            this.iconEyePass.Name = "iconEyePass";
            this.iconEyePass.Size = new System.Drawing.Size(32, 32);
            this.iconEyePass.TabIndex = 22;
            this.iconEyePass.TabStop = false;
            this.iconEyePass.Click += new System.EventHandler(this.iconEyePass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Re-Enter Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.iconPictureBox1);
            this.pnlFields.Controls.Add(this.label3);
            this.pnlFields.Controls.Add(this.edtFirstName);
            this.pnlFields.Controls.Add(this.label2);
            this.pnlFields.Controls.Add(this.edtLastName);
            this.pnlFields.Controls.Add(this.iconEyeRePas);
            this.pnlFields.Controls.Add(this.edtRoleNum);
            this.pnlFields.Controls.Add(this.iconEyePass);
            this.pnlFields.Controls.Add(this.iconPictureBox3);
            this.pnlFields.Controls.Add(this.edtEmail);
            this.pnlFields.Controls.Add(this.label1);
            this.pnlFields.Controls.Add(this.iconPictureBox2);
            this.pnlFields.Controls.Add(this.iconPictureBox7);
            this.pnlFields.Controls.Add(this.edtPassword);
            this.pnlFields.Controls.Add(this.edtPhoneNo);
            this.pnlFields.Controls.Add(this.edtRePassword);
            this.pnlFields.Controls.Add(this.iconPictureBox6);
            this.pnlFields.Controls.Add(this.cbxRole);
            this.pnlFields.Controls.Add(this.iconPictureBox5);
            this.pnlFields.Controls.Add(this.iconRole);
            this.pnlFields.Controls.Add(this.iconRoleNum);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(0, 137);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(499, 622);
            this.pnlFields.TabIndex = 26;
            this.pnlFields.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFields_Paint);
            // 
            // edtFirstName
            // 
            this.edtFirstName.BackColor = System.Drawing.Color.White;
            this.edtFirstName.customText = "First Name:";
            this.edtFirstName.Location = new System.Drawing.Point(102, 34);
            this.edtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtFirstName.Name = "edtFirstName";
            this.edtFirstName.password = false;
            this.edtFirstName.Size = new System.Drawing.Size(335, 53);
            this.edtFirstName.TabIndex = 0;
            this.edtFirstName.Load += new System.EventHandler(this.edtFirstName_Load);
            // 
            // edtLastName
            // 
            this.edtLastName.BackColor = System.Drawing.Color.White;
            this.edtLastName.customText = "Last Name:";
            this.edtLastName.Location = new System.Drawing.Point(102, 102);
            this.edtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtLastName.Name = "edtLastName";
            this.edtLastName.password = false;
            this.edtLastName.Size = new System.Drawing.Size(335, 53);
            this.edtLastName.TabIndex = 1;
            this.edtLastName.Load += new System.EventHandler(this.edtLastName_Load);
            // 
            // edtRoleNum
            // 
            this.edtRoleNum.BackColor = System.Drawing.Color.White;
            this.edtRoleNum.customText = "Student number:";
            this.edtRoleNum.Location = new System.Drawing.Point(102, 250);
            this.edtRoleNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtRoleNum.Name = "edtRoleNum";
            this.edtRoleNum.password = false;
            this.edtRoleNum.Size = new System.Drawing.Size(335, 53);
            this.edtRoleNum.TabIndex = 3;
            this.edtRoleNum.Load += new System.EventHandler(this.edtRoleNum_Load);
            // 
            // edtEmail
            // 
            this.edtEmail.BackColor = System.Drawing.Color.White;
            this.edtEmail.customText = "Email Address:";
            this.edtEmail.Location = new System.Drawing.Point(102, 386);
            this.edtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtEmail.Name = "edtEmail";
            this.edtEmail.password = false;
            this.edtEmail.Size = new System.Drawing.Size(335, 53);
            this.edtEmail.TabIndex = 5;
            this.edtEmail.Load += new System.EventHandler(this.edtEmail_Load);
            // 
            // edtPhoneNo
            // 
            this.edtPhoneNo.BackColor = System.Drawing.Color.White;
            this.edtPhoneNo.customText = "Phone Number:";
            this.edtPhoneNo.Location = new System.Drawing.Point(102, 316);
            this.edtPhoneNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtPhoneNo.Name = "edtPhoneNo";
            this.edtPhoneNo.password = false;
            this.edtPhoneNo.Size = new System.Drawing.Size(335, 53);
            this.edtPhoneNo.TabIndex = 4;
            this.edtPhoneNo.Load += new System.EventHandler(this.edtPhoneNo_Load);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(499, 859);
            this.Controls.Add(this.pnlFields);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRoleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyeRePas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyePass)).EndInit();
            this.pnlFields.ResumeLayout(false);
            this.pnlFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnSignUp;
        private System.Windows.Forms.Panel panel3;
        private TestingIS.Components.BookITTextBox edtFirstName;
        private TestingIS.Components.BookITTextBox edtLastName;
        private TestingIS.Components.BookITTextBox edtRoleNum;
        private TestingIS.Components.BookITTextBox edtEmail;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.TextBox edtPassword;
        private System.Windows.Forms.TextBox edtRePassword;
        private System.Windows.Forms.ComboBox cbxRole;
        private FontAwesome.Sharp.IconPictureBox iconRole;
        private FontAwesome.Sharp.IconPictureBox iconRoleNum;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private TestingIS.Components.BookITTextBox edtPhoneNo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconEyeRePas;
        private FontAwesome.Sharp.IconPictureBox iconEyePass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlFields;
        private FontAwesome.Sharp.IconButton btnBack;
    }
}