namespace BookITFinal.Forms
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.btnEditLName = new FontAwesome.Sharp.IconButton();
            this.btnEditFName = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblContactAdmin = new System.Windows.Forms.Label();
            this.btnEditEmail = new FontAwesome.Sharp.IconButton();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.tblpAccount = new System.Windows.Forms.TableLayoutPanel();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnEditContactNo = new FontAwesome.Sharp.IconButton();
            this.btnEditPass = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.tblpAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditLName
            // 
            this.btnEditLName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditLName.FlatAppearance.BorderSize = 0;
            this.btnEditLName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditLName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditLName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLName.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditLName.IconColor = System.Drawing.Color.White;
            this.btnEditLName.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEditLName.IconSize = 25;
            this.btnEditLName.Location = new System.Drawing.Point(518, 61);
            this.btnEditLName.Name = "btnEditLName";
            this.btnEditLName.Size = new System.Drawing.Size(84, 42);
            this.btnEditLName.TabIndex = 7;
            this.btnEditLName.UseVisualStyleBackColor = true;
            this.btnEditLName.Click += new System.EventHandler(this.btnEditLName_Click);
            // 
            // btnEditFName
            // 
            this.btnEditFName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditFName.FlatAppearance.BorderSize = 0;
            this.btnEditFName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditFName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditFName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFName.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditFName.IconColor = System.Drawing.Color.White;
            this.btnEditFName.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEditFName.IconSize = 25;
            this.btnEditFName.Location = new System.Drawing.Point(518, 13);
            this.btnEditFName.Name = "btnEditFName";
            this.btnEditFName.Size = new System.Drawing.Size(84, 42);
            this.btnEditFName.TabIndex = 6;
            this.btnEditFName.UseVisualStyleBackColor = true;
            this.btnEditFName.Click += new System.EventHandler(this.btnEditFName_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 249;
            this.iconPictureBox1.Location = new System.Drawing.Point(535, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(249, 251);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblContactAdmin
            // 
            this.lblContactAdmin.AutoSize = true;
            this.lblContactAdmin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactAdmin.Location = new System.Drawing.Point(467, 657);
            this.lblContactAdmin.Name = "lblContactAdmin";
            this.lblContactAdmin.Size = new System.Drawing.Size(382, 19);
            this.lblContactAdmin.TabIndex = 8;
            this.lblContactAdmin.Text = "To edit other details, please contact an admin";
            // 
            // btnEditEmail
            // 
            this.btnEditEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditEmail.FlatAppearance.BorderSize = 0;
            this.btnEditEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmail.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditEmail.IconColor = System.Drawing.Color.White;
            this.btnEditEmail.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEditEmail.IconSize = 25;
            this.btnEditEmail.Location = new System.Drawing.Point(518, 109);
            this.btnEditEmail.Name = "btnEditEmail";
            this.btnEditEmail.Size = new System.Drawing.Size(84, 42);
            this.btnEditEmail.TabIndex = 8;
            this.btnEditEmail.UseVisualStyleBackColor = true;
            this.btnEditEmail.Visible = false;
            this.btnEditEmail.Click += new System.EventHandler(this.btnEditEmail_Click);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContactNo.Location = new System.Drawing.Point(13, 154);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(499, 48);
            this.lblContactNo.TabIndex = 5;
            this.lblContactNo.Text = "084 724 0098";
            this.lblContactNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(13, 106);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(499, 48);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "2562592@students.wits.ac.za";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(173)))));
            this.lblLName.Location = new System.Drawing.Point(13, 58);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(499, 48);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Espialadocious";
            this.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(173)))));
            this.lblFName.Location = new System.Drawing.Point(13, 10);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(499, 48);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "Supercalifragilistic";
            this.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblpAccount
            // 
            this.tblpAccount.AllowDrop = true;
            this.tblpAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblpAccount.AutoScroll = true;
            this.tblpAccount.ColumnCount = 2;
            this.tblpAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tblpAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblpAccount.Controls.Add(this.lblRole, 0, 4);
            this.tblpAccount.Controls.Add(this.btnEditContactNo, 1, 3);
            this.tblpAccount.Controls.Add(this.btnEditEmail, 1, 2);
            this.tblpAccount.Controls.Add(this.btnEditLName, 1, 1);
            this.tblpAccount.Controls.Add(this.lblFName, 0, 0);
            this.tblpAccount.Controls.Add(this.lblLName, 0, 1);
            this.tblpAccount.Controls.Add(this.lblEmail, 0, 2);
            this.tblpAccount.Controls.Add(this.btnEditFName, 1, 0);
            this.tblpAccount.Controls.Add(this.lblContactNo, 0, 3);
            this.tblpAccount.Location = new System.Drawing.Point(397, 276);
            this.tblpAccount.Margin = new System.Windows.Forms.Padding(10);
            this.tblpAccount.Name = "tblpAccount";
            this.tblpAccount.Padding = new System.Windows.Forms.Padding(10);
            this.tblpAccount.RowCount = 5;
            this.tblpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpAccount.Size = new System.Drawing.Size(615, 264);
            this.tblpAccount.TabIndex = 6;
            this.tblpAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.tblpAccount_Paint);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRole.Location = new System.Drawing.Point(13, 202);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(499, 52);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "Student";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditContactNo
            // 
            this.btnEditContactNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditContactNo.FlatAppearance.BorderSize = 0;
            this.btnEditContactNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditContactNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditContactNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditContactNo.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditContactNo.IconColor = System.Drawing.Color.White;
            this.btnEditContactNo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEditContactNo.IconSize = 25;
            this.btnEditContactNo.Location = new System.Drawing.Point(518, 157);
            this.btnEditContactNo.Name = "btnEditContactNo";
            this.btnEditContactNo.Size = new System.Drawing.Size(84, 42);
            this.btnEditContactNo.TabIndex = 9;
            this.btnEditContactNo.UseVisualStyleBackColor = true;
            this.btnEditContactNo.Visible = false;
            this.btnEditContactNo.Click += new System.EventHandler(this.btnEditContactNo_Click);
            // 
            // btnEditPass
            // 
            this.btnEditPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.btnEditPass.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEditPass.IconColor = System.Drawing.Color.White;
            this.btnEditPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditPass.Location = new System.Drawing.Point(580, 564);
            this.btnEditPass.Name = "btnEditPass";
            this.btnEditPass.Size = new System.Drawing.Size(153, 50);
            this.btnEditPass.TabIndex = 9;
            this.btnEditPass.Text = "Edit Password";
            this.btnEditPass.UseVisualStyleBackColor = false;
            this.btnEditPass.Click += new System.EventHandler(this.btnEditPass_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1236, 701);
            this.Controls.Add(this.btnEditPass);
            this.Controls.Add(this.lblContactAdmin);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.tblpAccount);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.tblpAccount.ResumeLayout(false);
            this.tblpAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnEditFName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnEditLName;
        private System.Windows.Forms.Label lblContactAdmin;
        private FontAwesome.Sharp.IconButton btnEditEmail;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TableLayoutPanel tblpAccount;
        private FontAwesome.Sharp.IconButton btnEditContactNo;
        private System.Windows.Forms.Label lblRole;
        private FontAwesome.Sharp.IconButton btnEditPass;
    }
}