namespace BookITFinal.Forms
{
    partial class VenueSearch
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
            this.VenueFilterMenu = new System.Windows.Forms.ComboBox();
            this.VenueSearchBox1 = new System.Windows.Forms.TextBox();
            this.dgvVenue = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenue)).BeginInit();
            this.SuspendLayout();
            // 
            // VenueFilterMenu
            // 
            this.VenueFilterMenu.FormattingEnabled = true;
            this.VenueFilterMenu.Items.AddRange(new object[] {
            "Venue Capacity :",
            "2-10",
            "11-50",
            "51-100",
            "100-300",
            "300+"});
            this.VenueFilterMenu.Location = new System.Drawing.Point(524, 112);
            this.VenueFilterMenu.Name = "VenueFilterMenu";
            this.VenueFilterMenu.Size = new System.Drawing.Size(207, 21);
            this.VenueFilterMenu.TabIndex = 11;
            this.VenueFilterMenu.Text = "Filter ";
            // 
            // VenueSearchBox1
            // 
            this.VenueSearchBox1.Location = new System.Drawing.Point(69, 113);
            this.VenueSearchBox1.Name = "VenueSearchBox1";
            this.VenueSearchBox1.Size = new System.Drawing.Size(278, 20);
            this.VenueSearchBox1.TabIndex = 10;
            this.VenueSearchBox1.Text = "Search";
            // 
            // dgvVenue
            // 
            this.dgvVenue.AllowUserToAddRows = false;
            this.dgvVenue.AllowUserToDeleteRows = false;
            this.dgvVenue.AllowUserToResizeColumns = false;
            this.dgvVenue.AllowUserToResizeRows = false;
            this.dgvVenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenue.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenue.Location = new System.Drawing.Point(69, 168);
            this.dgvVenue.Name = "dgvVenue";
            this.dgvVenue.Size = new System.Drawing.Size(662, 252);
            this.dgvVenue.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(303, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "Venue Search";
            // 
            // VenueSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VenueFilterMenu);
            this.Controls.Add(this.VenueSearchBox1);
            this.Controls.Add(this.dgvVenue);
            this.Controls.Add(this.label1);
            this.Name = "VenueSearch";
            this.Text = "VenueSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VenueFilterMenu;
        private System.Windows.Forms.TextBox VenueSearchBox1;
        private System.Windows.Forms.DataGridView dgvVenue;
        private System.Windows.Forms.Label label1;
    }
}