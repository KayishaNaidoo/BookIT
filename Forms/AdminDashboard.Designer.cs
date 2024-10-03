namespace BookITFinal.Forms
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.cPastBookings = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCreateBooking = new FontAwesome.Sharp.IconButton();
            this.cbxUserID = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCreateUser = new FontAwesome.Sharp.IconButton();
            this.lblNumUsers = new System.Windows.Forms.Label();
            this.lblNumBookings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPastBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBookings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookings.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookings.GridColor = System.Drawing.Color.Silver;
            this.dgvBookings.Location = new System.Drawing.Point(59, 119);
            this.dgvBookings.Margin = new System.Windows.Forms.Padding(5);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.dgvBookings.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookings.RowTemplate.Height = 24;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBookings.Size = new System.Drawing.Size(1119, 269);
            this.dgvBookings.TabIndex = 6;
            // 
            // cPastBookings
            // 
            this.cPastBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.cPastBookings.BackImageTransparentColor = System.Drawing.Color.White;
            this.cPastBookings.BackSecondaryColor = System.Drawing.Color.WhiteSmoke;
            this.cPastBookings.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            chartArea2.Name = "ChartArea1";
            this.cPastBookings.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cPastBookings.Legends.Add(legend2);
            this.cPastBookings.Location = new System.Drawing.Point(644, 396);
            this.cPastBookings.Name = "cPastBookings";
            this.cPastBookings.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.cPastBookings.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(173))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(50)))), ((int)(((byte)(94))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(162)))), ((int)(((byte)(200))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(126)))), ((int)(((byte)(220))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(102)))), ((int)(((byte)(205))))),
        System.Drawing.Color.DarkOrchid,
        System.Drawing.Color.MediumSlateBlue};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.Black;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cPastBookings.Series.Add(series2);
            this.cPastBookings.Size = new System.Drawing.Size(510, 286);
            this.cPastBookings.TabIndex = 5;
            title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            title2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            this.cPastBookings.Titles.Add(title2);
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.btnCreateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBooking.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBooking.ForeColor = System.Drawing.Color.White;
            this.btnCreateBooking.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCreateBooking.IconColor = System.Drawing.Color.Black;
            this.btnCreateBooking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateBooking.Location = new System.Drawing.Point(59, 499);
            this.btnCreateBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(543, 62);
            this.btnCreateBooking.TabIndex = 4;
            this.btnCreateBooking.Text = "CREATE BOOKING";
            this.btnCreateBooking.UseVisualStyleBackColor = false;
            // 
            // cbxUserID
            // 
            this.cbxUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserID.FormattingEnabled = true;
            this.cbxUserID.Location = new System.Drawing.Point(156, 68);
            this.cbxUserID.Name = "cbxUserID";
            this.cbxUserID.Size = new System.Drawing.Size(171, 31);
            this.cbxUserID.TabIndex = 7;
            this.cbxUserID.SelectedIndexChanged += new System.EventHandler(this.cbxUserID_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(73, 71);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 23);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "UserID:";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.ForeColor = System.Drawing.Color.White;
            this.btnCreateUser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCreateUser.IconColor = System.Drawing.Color.Black;
            this.btnCreateUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateUser.Location = new System.Drawing.Point(59, 583);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(543, 62);
            this.btnCreateUser.TabIndex = 9;
            this.btnCreateUser.Text = "CREATE NEW USER";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // lblNumUsers
            // 
            this.lblNumUsers.AutoSize = true;
            this.lblNumUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumUsers.Location = new System.Drawing.Point(73, 434);
            this.lblNumUsers.Name = "lblNumUsers";
            this.lblNumUsers.Size = new System.Drawing.Size(117, 23);
            this.lblNumUsers.TabIndex = 10;
            this.lblNumUsers.Text = "Total Users:";
            // 
            // lblNumBookings
            // 
            this.lblNumBookings.AutoSize = true;
            this.lblNumBookings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBookings.Location = new System.Drawing.Point(347, 434);
            this.lblNumBookings.Name = "lblNumBookings";
            this.lblNumBookings.Size = new System.Drawing.Size(156, 23);
            this.lblNumBookings.TabIndex = 11;
            this.lblNumBookings.Text = "Total Bookings:";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1236, 701);
            this.Controls.Add(this.lblNumBookings);
            this.Controls.Add(this.lblNumUsers);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cbxUserID);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.cPastBookings);
            this.Controls.Add(this.btnCreateBooking);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPastBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.DataVisualization.Charting.Chart cPastBookings;
        private FontAwesome.Sharp.IconButton btnCreateBooking;
        private System.Windows.Forms.ComboBox cbxUserID;
        private System.Windows.Forms.Label lblUser;
        private FontAwesome.Sharp.IconButton btnCreateUser;
        private System.Windows.Forms.Label lblNumUsers;
        private System.Windows.Forms.Label lblNumBookings;
    }
}