namespace BookITFinal.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconEyePass = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.edtPassword = new System.Windows.Forms.TextBox();
            this.iconRole = new FontAwesome.Sharp.IconPictureBox();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.edtRoleNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRole)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(4);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(490, 225);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Password:";
            // 
            // iconEyePass
            // 
            this.iconEyePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.iconEyePass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconEyePass.IconColor = System.Drawing.Color.White;
            this.iconEyePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEyePass.Location = new System.Drawing.Point(403, 402);
            this.iconEyePass.Name = "iconEyePass";
            this.iconEyePass.Size = new System.Drawing.Size(32, 32);
            this.iconEyePass.TabIndex = 27;
            this.iconEyePass.TabStop = false;
            this.iconEyePass.Click += new System.EventHandler(this.iconEyePass_Click);
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox6.IconColor = System.Drawing.Color.White;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.Location = new System.Drawing.Point(50, 402);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox6.TabIndex = 26;
            this.iconPictureBox6.TabStop = false;
            // 
            // edtPassword
            // 
            this.edtPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPassword.Location = new System.Drawing.Point(100, 404);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.PasswordChar = '#';
            this.edtPassword.Size = new System.Drawing.Size(297, 30);
            this.edtPassword.TabIndex = 1;
            // 
            // iconRole
            // 
            this.iconRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.iconRole.IconChar = FontAwesome.Sharp.IconChar.Glasses;
            this.iconRole.IconColor = System.Drawing.Color.White;
            this.iconRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRole.Location = new System.Drawing.Point(53, 311);
            this.iconRole.Name = "iconRole";
            this.iconRole.Size = new System.Drawing.Size(32, 32);
            this.iconRole.TabIndex = 29;
            this.iconRole.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.btnLogin.IconColor = System.Drawing.Color.White;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLogin.Location = new System.Drawing.Point(173, 477);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(137, 56);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // edtRoleNumber
            // 
            this.edtRoleNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtRoleNumber.Location = new System.Drawing.Point(100, 311);
            this.edtRoleNumber.Name = "edtRoleNumber";
            this.edtRoleNumber.Size = new System.Drawing.Size(335, 32);
            this.edtRoleNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Student / Employee Number:\r\n";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnBack.IconColor = System.Drawing.Color.White;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnBack.Location = new System.Drawing.Point(0, 572);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(52, 44);
            this.btnBack.TabIndex = 31;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(490, 616);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtRoleNumber);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.iconRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconEyePass);
            this.Controls.Add(this.iconPictureBox6);
            this.Controls.Add(this.edtPassword);
            this.Controls.Add(this.imgLogo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEyePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconEyePass;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private System.Windows.Forms.TextBox edtPassword;
        private FontAwesome.Sharp.IconPictureBox iconRole;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.TextBox edtRoleNumber;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnBack;
    }
}