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
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.cbxStartTimes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEndTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCapacity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateBooking = new FontAwesome.Sharp.IconButton();
            this.cbxEventType = new System.Windows.Forms.ComboBox();
            this.gbEquipment = new System.Windows.Forms.GroupBox();
            this.cProjector = new System.Windows.Forms.CheckBox();
            this.cMicrophone = new System.Windows.Forms.CheckBox();
            this.cWhiteboard = new System.Windows.Forms.CheckBox();
            this.cSpeakers = new System.Windows.Forms.CheckBox();
            this.cCamera = new System.Windows.Forms.CheckBox();
            this.cTelevisions = new System.Windows.Forms.CheckBox();
            this.cChairs = new System.Windows.Forms.CheckBox();
            this.cComputers = new System.Windows.Forms.CheckBox();
            this.cPlugpoints = new System.Windows.Forms.CheckBox();
            this.cAircons = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.gbEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookings
            // 
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(639, 29);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.RowTemplate.Height = 24;
            this.dgvBookings.Size = new System.Drawing.Size(534, 447);
            this.dgvBookings.TabIndex = 1;
            this.dgvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookings_CellContentClick);
            // 
            // cbxStartTimes
            // 
            this.cbxStartTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.cbxStartTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStartTimes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStartTimes.ForeColor = System.Drawing.Color.White;
            this.cbxStartTimes.FormattingEnabled = true;
            this.cbxStartTimes.Location = new System.Drawing.Point(46, 116);
            this.cbxStartTimes.Name = "cbxStartTimes";
            this.cbxStartTimes.Size = new System.Drawing.Size(268, 31);
            this.cbxStartTimes.TabIndex = 3;
            this.cbxStartTimes.SelectedIndexChanged += new System.EventHandler(this.cbxStartTimes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(341, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Time:";
            // 
            // cbxEndTime
            // 
            this.cbxEndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.cbxEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEndTime.Enabled = false;
            this.cbxEndTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEndTime.ForeColor = System.Drawing.Color.White;
            this.cbxEndTime.FormattingEnabled = true;
            this.cbxEndTime.Items.AddRange(new object[] {
            "8am"});
            this.cbxEndTime.Location = new System.Drawing.Point(345, 116);
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
            this.cbxCapacity.Location = new System.Drawing.Point(345, 39);
            this.cbxCapacity.Name = "cbxCapacity";
            this.cbxCapacity.Size = new System.Drawing.Size(268, 31);
            this.cbxCapacity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(347, 17);
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
            this.btnCreateBooking.Location = new System.Drawing.Point(189, 423);
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
            this.cbxEventType.Location = new System.Drawing.Point(46, 39);
            this.cbxEventType.Name = "cbxEventType";
            this.cbxEventType.Size = new System.Drawing.Size(268, 31);
            this.cbxEventType.TabIndex = 13;
            // 
            // gbEquipment
            // 
            this.gbEquipment.Controls.Add(this.cAircons);
            this.gbEquipment.Controls.Add(this.cPlugpoints);
            this.gbEquipment.Controls.Add(this.cComputers);
            this.gbEquipment.Controls.Add(this.cChairs);
            this.gbEquipment.Controls.Add(this.cTelevisions);
            this.gbEquipment.Controls.Add(this.cCamera);
            this.gbEquipment.Controls.Add(this.cSpeakers);
            this.gbEquipment.Controls.Add(this.cWhiteboard);
            this.gbEquipment.Controls.Add(this.cMicrophone);
            this.gbEquipment.Controls.Add(this.cProjector);
            this.gbEquipment.ForeColor = System.Drawing.Color.White;
            this.gbEquipment.Location = new System.Drawing.Point(151, 196);
            this.gbEquipment.Name = "gbEquipment";
            this.gbEquipment.Size = new System.Drawing.Size(358, 188);
            this.gbEquipment.TabIndex = 14;
            this.gbEquipment.TabStop = false;
            this.gbEquipment.Text = "Equipment Needed";
            // 
            // cProjector
            // 
            this.cProjector.AutoSize = true;
            this.cProjector.Location = new System.Drawing.Point(19, 27);
            this.cProjector.Name = "cProjector";
            this.cProjector.Size = new System.Drawing.Size(103, 23);
            this.cProjector.TabIndex = 0;
            this.cProjector.Text = "Projector";
            this.cProjector.UseVisualStyleBackColor = true;
            // 
            // cMicrophone
            // 
            this.cMicrophone.AutoSize = true;
            this.cMicrophone.Location = new System.Drawing.Point(19, 56);
            this.cMicrophone.Name = "cMicrophone";
            this.cMicrophone.Size = new System.Drawing.Size(130, 23);
            this.cMicrophone.TabIndex = 1;
            this.cMicrophone.Text = "Microphone";
            this.cMicrophone.UseVisualStyleBackColor = true;
            // 
            // cWhiteboard
            // 
            this.cWhiteboard.AutoSize = true;
            this.cWhiteboard.Location = new System.Drawing.Point(19, 85);
            this.cWhiteboard.Name = "cWhiteboard";
            this.cWhiteboard.Size = new System.Drawing.Size(124, 23);
            this.cWhiteboard.TabIndex = 2;
            this.cWhiteboard.Text = "Whiteboard";
            this.cWhiteboard.UseVisualStyleBackColor = true;
            // 
            // cSpeakers
            // 
            this.cSpeakers.AutoSize = true;
            this.cSpeakers.Location = new System.Drawing.Point(19, 114);
            this.cSpeakers.Name = "cSpeakers";
            this.cSpeakers.Size = new System.Drawing.Size(107, 23);
            this.cSpeakers.TabIndex = 3;
            this.cSpeakers.Text = "Speakers";
            this.cSpeakers.UseVisualStyleBackColor = true;
            // 
            // cCamera
            // 
            this.cCamera.AutoSize = true;
            this.cCamera.Location = new System.Drawing.Point(19, 143);
            this.cCamera.Name = "cCamera";
            this.cCamera.Size = new System.Drawing.Size(98, 23);
            this.cCamera.TabIndex = 4;
            this.cCamera.Text = "Camera";
            this.cCamera.UseVisualStyleBackColor = true;
            // 
            // cTelevisions
            // 
            this.cTelevisions.AutoSize = true;
            this.cTelevisions.Location = new System.Drawing.Point(170, 85);
            this.cTelevisions.Name = "cTelevisions";
            this.cTelevisions.Size = new System.Drawing.Size(119, 23);
            this.cTelevisions.TabIndex = 5;
            this.cTelevisions.Text = "Televisions";
            this.cTelevisions.UseVisualStyleBackColor = true;
            // 
            // cChairs
            // 
            this.cChairs.AutoSize = true;
            this.cChairs.Location = new System.Drawing.Point(170, 56);
            this.cChairs.Name = "cChairs";
            this.cChairs.Size = new System.Drawing.Size(176, 23);
            this.cChairs.TabIndex = 6;
            this.cChairs.Text = "Chairs and Tables";
            this.cChairs.UseVisualStyleBackColor = true;
            // 
            // cComputers
            // 
            this.cComputers.AutoSize = true;
            this.cComputers.Location = new System.Drawing.Point(170, 27);
            this.cComputers.Name = "cComputers";
            this.cComputers.Size = new System.Drawing.Size(120, 23);
            this.cComputers.TabIndex = 7;
            this.cComputers.Text = "Computers";
            this.cComputers.UseVisualStyleBackColor = true;
            // 
            // cPlugpoints
            // 
            this.cPlugpoints.AutoSize = true;
            this.cPlugpoints.Location = new System.Drawing.Point(170, 114);
            this.cPlugpoints.Name = "cPlugpoints";
            this.cPlugpoints.Size = new System.Drawing.Size(114, 23);
            this.cPlugpoints.TabIndex = 8;
            this.cPlugpoints.Text = "Plugpoints";
            this.cPlugpoints.UseVisualStyleBackColor = true;
            // 
            // cAircons
            // 
            this.cAircons.AutoSize = true;
            this.cAircons.Location = new System.Drawing.Point(170, 143);
            this.cAircons.Name = "cAircons";
            this.cAircons.Size = new System.Drawing.Size(160, 23);
            this.cAircons.TabIndex = 9;
            this.cAircons.Text = "Air Conditioners";
            this.cAircons.UseVisualStyleBackColor = true;
            // 
            // CreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(26)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1218, 547);
            this.Controls.Add(this.gbEquipment);
            this.Controls.Add(this.cbxEventType);
            this.Controls.Add(this.btnCreateBooking);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxCapacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxEndTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxStartTimes);
            this.Controls.Add(this.dgvBookings);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateBooking";
            this.Text = "CreateBooking";
            this.Load += new System.EventHandler(this.CreateBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.gbEquipment.ResumeLayout(false);
            this.gbEquipment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.ComboBox cbxStartTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEndTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCapacity;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnCreateBooking;
        private System.Windows.Forms.ComboBox cbxEventType;
        private System.Windows.Forms.GroupBox gbEquipment;
        private System.Windows.Forms.CheckBox cCamera;
        private System.Windows.Forms.CheckBox cSpeakers;
        private System.Windows.Forms.CheckBox cWhiteboard;
        private System.Windows.Forms.CheckBox cMicrophone;
        private System.Windows.Forms.CheckBox cProjector;
        private System.Windows.Forms.CheckBox cAircons;
        private System.Windows.Forms.CheckBox cPlugpoints;
        private System.Windows.Forms.CheckBox cComputers;
        private System.Windows.Forms.CheckBox cChairs;
        private System.Windows.Forms.CheckBox cTelevisions;
    }
}