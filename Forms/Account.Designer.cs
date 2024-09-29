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
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.tblpAccount = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditFName = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnEditLName = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tblpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(173)))));
            this.lblFName.Location = new System.Drawing.Point(13, 10);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(537, 58);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "Supercalifragilistic";
            this.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(173)))));
            this.lblLName.Location = new System.Drawing.Point(13, 68);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(537, 58);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Espialadocious";
            this.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(13, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(537, 58);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "2562592@students.wits.ac.za";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContactNo.Location = new System.Drawing.Point(13, 184);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(537, 61);
            this.lblContactNo.TabIndex = 5;
            this.lblContactNo.Text = "084 724 0098";
            this.lblContactNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblpAccount
            // 
            this.tblpAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblpAccount.AutoScroll = true;
            this.tblpAccount.ColumnCount = 2;
            this.tblpAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpAccount.Controls.Add(this.btnEditLName, 1, 1);
            this.tblpAccount.Controls.Add(this.lblFName, 0, 0);
            this.tblpAccount.Controls.Add(this.lblLName, 0, 1);
            this.tblpAccount.Controls.Add(this.lblEmail, 0, 2);
            this.tblpAccount.Controls.Add(this.btnEditFName, 1, 0);
            this.tblpAccount.Controls.Add(this.lblContactNo, 0, 3);
            this.tblpAccount.Location = new System.Drawing.Point(363, 276);
            this.tblpAccount.Margin = new System.Windows.Forms.Padding(10);
            this.tblpAccount.Name = "tblpAccount";
            this.tblpAccount.Padding = new System.Windows.Forms.Padding(10);
            this.tblpAccount.RowCount = 4;
            this.tblpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpAccount.Size = new System.Drawing.Size(615, 255);
            this.tblpAccount.TabIndex = 6;
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
            this.btnEditFName.Location = new System.Drawing.Point(556, 13);
            this.btnEditFName.Name = "btnEditFName";
            this.btnEditFName.Size = new System.Drawing.Size(46, 52);
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
            this.iconPictureBox1.Location = new System.Drawing.Point(519, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(249, 251);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
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
            this.btnEditLName.Location = new System.Drawing.Point(556, 71);
            this.btnEditLName.Name = "btnEditLName";
            this.btnEditLName.Size = new System.Drawing.Size(46, 52);
            this.btnEditLName.TabIndex = 7;
            this.btnEditLName.UseVisualStyleBackColor = true;
            this.btnEditLName.Click += new System.EventHandler(this.btnEditLName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 657);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "To edit other details, please contact an admin";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1236, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.tblpAccount);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.tblpAccount.ResumeLayout(false);
            this.tblpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TableLayoutPanel tblpAccount;
        private FontAwesome.Sharp.IconButton btnEditFName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnEditLName;
        private System.Windows.Forms.Label label1;
    }
}