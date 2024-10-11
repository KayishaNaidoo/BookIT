namespace BookITFinal.Components
{
    partial class popUpBook
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
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnCancelB = new FontAwesome.Sharp.IconButton();
            this.btnUpdateB = new FontAwesome.Sharp.IconButton();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(238, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 30);
            this.btnClose.TabIndex = 22;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancelB
            // 
            this.btnCancelB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelB.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelB.ForeColor = System.Drawing.Color.White;
            this.btnCancelB.IconChar = FontAwesome.Sharp.IconChar.Neuter;
            this.btnCancelB.IconColor = System.Drawing.Color.White;
            this.btnCancelB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelB.Location = new System.Drawing.Point(27, 74);
            this.btnCancelB.Name = "btnCancelB";
            this.btnCancelB.Size = new System.Drawing.Size(228, 54);
            this.btnCancelB.TabIndex = 23;
            this.btnCancelB.Text = "CANCEL BOOKING";
            this.btnCancelB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelB.UseVisualStyleBackColor = true;
            this.btnCancelB.Click += new System.EventHandler(this.btnCancelB_Click);
            // 
            // btnUpdateB
            // 
            this.btnUpdateB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateB.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateB.ForeColor = System.Drawing.Color.White;
            this.btnUpdateB.IconChar = FontAwesome.Sharp.IconChar.Neuter;
            this.btnUpdateB.IconColor = System.Drawing.Color.White;
            this.btnUpdateB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateB.Location = new System.Drawing.Point(27, 141);
            this.btnUpdateB.Name = "btnUpdateB";
            this.btnUpdateB.Size = new System.Drawing.Size(228, 54);
            this.btnUpdateB.TabIndex = 24;
            this.btnUpdateB.Text = "UPDATE BOOKING";
            this.btnUpdateB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateB.UseVisualStyleBackColor = true;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.ForeColor = System.Drawing.Color.White;
            this.lblBookingID.Location = new System.Drawing.Point(77, 19);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(110, 23);
            this.lblBookingID.TabIndex = 25;
            this.lblBookingID.Text = "BookingID";
            // 
            // popUpBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(276, 231);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.btnUpdateB);
            this.Controls.Add(this.btnCancelB);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popUpBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popUpBook";
            this.Load += new System.EventHandler(this.popUpBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnCancelB;
        private FontAwesome.Sharp.IconButton btnUpdateB;
        private System.Windows.Forms.Label lblBookingID;
    }
}