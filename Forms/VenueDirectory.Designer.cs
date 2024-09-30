namespace BookITFinal.Forms
{
    partial class VenueDirectory
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
            this.VenueFilterMenu1 = new System.Windows.Forms.ComboBox();
            this.VenueSearchBox1 = new System.Windows.Forms.TextBox();
            this.dgvVenue1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenue1)).BeginInit();
            this.SuspendLayout();
            // 
            // VenueFilterMenu1
            // 
            this.VenueFilterMenu1.FormattingEnabled = true;
            this.VenueFilterMenu1.Items.AddRange(new object[] {
            "Venue Capacity : 2-10",
            "Venue Capacity : 11-50",
            "Venue Capacity : 51-100",
            "Venue Capacity : 100-300",
            "Venue Capacity : 300+",
            "",
            "Equipment : Projector",
            "Equipment : Microphone",
            "Equipment : Whiteboard",
            "Equipment : Speakers",
            "Equipment : Camera",
            "Equipment : Computer",
            "Equipment : Chairs",
            "Equipment : Tables",
            "Equipment : Television",
            "Equipment : Plugs",
            "Equipment : Airconditioners",
            "",
            "Category : THEATRE",
            "Category : TUTORIAL",
            "Category : MEETING",
            "Category : EXAM"});
            this.VenueFilterMenu1.Location = new System.Drawing.Point(524, 112);
            this.VenueFilterMenu1.Name = "VenueFilterMenu1";
            this.VenueFilterMenu1.Size = new System.Drawing.Size(207, 21);
            this.VenueFilterMenu1.TabIndex = 7;
            this.VenueFilterMenu1.Text = "Filter ";
            // 
            // VenueSearchBox1
            // 
            this.VenueSearchBox1.Location = new System.Drawing.Point(69, 113);
            this.VenueSearchBox1.Name = "VenueSearchBox1";
            this.VenueSearchBox1.Size = new System.Drawing.Size(278, 20);
            this.VenueSearchBox1.TabIndex = 6;
            this.VenueSearchBox1.Text = "Search";
            this.VenueSearchBox1.TextChanged += new System.EventHandler(this.VenueSearchBox1_TextChanged);
            // 
            // dgvVenue1
            // 
            this.dgvVenue1.AllowUserToAddRows = false;
            this.dgvVenue1.AllowUserToDeleteRows = false;
            this.dgvVenue1.AllowUserToResizeColumns = false;
            this.dgvVenue1.AllowUserToResizeRows = false;
            this.dgvVenue1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVenue1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenue1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVenue1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenue1.Location = new System.Drawing.Point(69, 168);
            this.dgvVenue1.Name = "dgvVenue1";
            this.dgvVenue1.Size = new System.Drawing.Size(662, 252);
            this.dgvVenue1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(303, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Venue Directory";
            // 
            // VenueDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VenueFilterMenu1);
            this.Controls.Add(this.VenueSearchBox1);
            this.Controls.Add(this.dgvVenue1);
            this.Controls.Add(this.label1);
            this.Name = "VenueDirectory";
            this.Text = "VenueDirectory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenue1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VenueFilterMenu1;
        private System.Windows.Forms.TextBox VenueSearchBox1;
        private System.Windows.Forms.DataGridView dgvVenue1;
        private System.Windows.Forms.Label label1;
    }
}