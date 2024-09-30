using BookITFinal.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookITFinal.Forms
{
    public partial class VenueSearch : Form
    {

        String VenueGrid;
        DatabaseHelper dbHelper = new DatabaseHelper();
        private SQLiteConnection con;
        string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Components", "Bookit.db");

        public VenueSearch()
        {
            InitializeComponent();
            con = new SQLiteConnection($"Data Source={databasePath}");
            this.Load += new EventHandler(VenueSearch_Load);  // Ensure Load event is attached
        }

        private void VenueSearch_Load(object sender, EventArgs e)
        {
            // Load all venues when the form loads
            LoadData();
        }
        public void LoadData()
        {
            con.Open();
            string sql = "SELECT v.VenueID, v.Capacity, v.Category, b.BuildingName, GROUP_CONCAT(e.EquipmentName) AS EquipmentList FROM Venue v JOIN Building b ON v.BuildingID = b.BuildingID JOIN VenueEquipment ve ON v.VenueID = ve.VenueID JOIN Equipment e ON ve.EquipmentID = e.EquipmentID GROUP BY v.VenueID;\r\n";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvVenue.DataSource = dt;
            con.Close();
        }

    }
}
