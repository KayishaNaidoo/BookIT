using BookITFinal.Components;
using FontAwesome.Sharp;
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
    public partial class VenueDirectory : Form
    {

        String VenueGrid;
        DatabaseHelper dbHelper = new DatabaseHelper();
        private SQLiteConnection con;
        string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Components", "Bookit.db");
        
        public VenueDirectory()
        {
            InitializeComponent();
            con = new SQLiteConnection($"Data Source={databasePath}");
            this.Load += new EventHandler(VenueDirectory_Load);  // Ensure Load event is attached
        }

        private void VenueDirectory_Load(object sender, EventArgs e)
        {
            // Load all venues when the form loads
            LoadData("SELECT v.VenueID, v.Capacity, v.Category, b.BuildingName, GROUP_CONCAT(e.EquipmentName) AS EquipmentList FROM Venue v JOIN Building b ON v.BuildingID = b.BuildingID JOIN VenueEquipment ve ON v.VenueID = ve.VenueID JOIN Equipment e ON ve.EquipmentID = e.EquipmentID GROUP BY v.VenueID;");
        }
        public void LoadData(String query)
        {
            con.Open();
            String sql = query;
            //String sql = "SELECT v.VenueID, v.Capacity, v.Category, b.BuildingName, GROUP_CONCAT(e.EquipmentName) AS EquipmentList FROM Venue v JOIN Building b ON v.BuildingID = b.BuildingID JOIN VenueEquipment ve ON v.VenueID = ve.VenueID JOIN Equipment e ON ve.EquipmentID = e.EquipmentID GROUP BY v.VenueID;";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvVenue1.DataSource = dt;
            con.Close();
        }

        private void VenueSearchBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = VenueSearchBox1.Text;
            LoadData($"SELECT * FROM Venues WHERE VenueName LIKE '%{searchQuery}%'");
            LoadData($"SELECT * FROM Venues WHERE VenueName LIKE '%{searchQuery}%'");
        }
    }
}
