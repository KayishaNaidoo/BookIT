namespace BookITFinal.Forms
{
    partial class CreateBooking
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.cbxStartTimes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEndTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCapacity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateBooking = new FontAwesome.Sharp.IconButton();
            this.cbxEventType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CausesValidation = false;
            this.monthCalendar1.Location = new System.Drawing.Point(52, 115);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // dgvBookings
            // 
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(409, 63);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.RowTemplate.Height = 24;
            this.dgvBookings.Size = new System.Drawing.Size(766, 564);
            this.dgvBookings.TabIndex = 1;
            this.dgvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookings_CellContentClick);
            // 
            // cbxStartTimes
            // 
            this.cbxStartTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStartTimes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStartTimes.FormattingEnabled = true;
            this.cbxStartTimes.Location = new System.Drawing.Point(46, 366);
            this.cbxStartTimes.Name = "cbxStartTimes";
            this.cbxStartTimes.Size = new System.Drawing.Size(268, 31);
            this.cbxStartTimes.TabIndex = 3;
            this.cbxStartTimes.SelectedIndexChanged += new System.EventHandler(this.cbxStartTimes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Time:";
            // 
            // cbxEndTime
            // 
            this.cbxEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEndTime.Enabled = false;
            this.cbxEndTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEndTime.FormattingEnabled = true;
            this.cbxEndTime.Items.AddRange(new object[] {
            "8am"});
            this.cbxEndTime.Location = new System.Drawing.Point(46, 428);
            this.cbxEndTime.Name = "cbxEndTime";
            this.cbxEndTime.Size = new System.Drawing.Size(268, 31);
            this.cbxEndTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Event Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date:";
            // 
            // cbxCapacity
            // 
            this.cbxCapacity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCapacity.FormattingEnabled = true;
            this.cbxCapacity.Items.AddRange(new object[] {
            "2-10",
            "11-50",
            "51-100",
            "100-300",
            "300+"});
            this.cbxCapacity.Location = new System.Drawing.Point(46, 509);
            this.cbxCapacity.Name = "cbxCapacity";
            this.cbxCapacity.Size = new System.Drawing.Size(268, 31);
            this.cbxCapacity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Required Capacity";
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBooking.ForeColor = System.Drawing.Color.White;
            this.btnCreateBooking.IconChar = FontAwesome.Sharp.IconChar.BuildingCircleCheck;
            this.btnCreateBooking.IconColor = System.Drawing.Color.White;
            this.btnCreateBooking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateBooking.IconSize = 30;
            this.btnCreateBooking.Location = new System.Drawing.Point(46, 574);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(268, 53);
            this.btnCreateBooking.TabIndex = 12;
            this.btnCreateBooking.Text = "CREATE NEW BOOKING";
            this.btnCreateBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // cbxEventType
            // 
            this.cbxEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEventType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEventType.FormattingEnabled = true;
            this.cbxEventType.Location = new System.Drawing.Point(52, 39);
            this.cbxEventType.Name = "cbxEventType";
            this.cbxEventType.Size = new System.Drawing.Size(262, 31);
            this.cbxEventType.TabIndex = 13;
            // 
            // CreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1218, 654);
            this.Controls.Add(this.cbxEventType);
            this.Controls.Add(this.btnCreateBooking);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxCapacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxEndTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxStartTimes);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.monthCalendar1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateBooking";
            this.Text = "CreateBooking";
            this.Load += new System.EventHandler(this.CreateBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.ComboBox cbxStartTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEndTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCapacity;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnCreateBooking;
        private System.Windows.Forms.ComboBox cbxEventType;
    }
}