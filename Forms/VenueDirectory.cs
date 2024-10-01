using BookITFinal.Colors;
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
       /* private SQLiteConnection con;
        string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Components", "Bookit.db");*/
        
        public VenueDirectory()
        {
            InitializeComponent();
            //con = new SQLiteConnection($"Data Source={databasePath}");
            //this.Load += new EventHandler(VenueDirectory_Load);  // Ensure Load event is attached
        }

        private void VenueDirectory_Load(object sender, EventArgs e)
        {
            // Load all venues when the form loads
            //LoadData("SELECT * FROM VenueDirectory");
            //LoadData("SELECT v.VenueID, v.Capacity, v.Category, b.BuildingName, GROUP_CONCAT(e.EquipmentName) AS EquipmentList FROM Venue v JOIN Building b ON v.BuildingID = b.BuildingID JOIN VenueEquipment ve ON v.VenueID = ve.VenueID JOIN Equipment e ON ve.EquipmentID = e.EquipmentID GROUP BY v.VenueID;");
        }
        public void LoadData(String query)
        {
           /*// con.Open();
            String sql = query;
            //String sql = "SELECT v.VenueID, v.Capacity, v.Category, b.BuildingName, GROUP_CONCAT(e.EquipmentName) AS EquipmentList FROM Venue v JOIN Building b ON v.BuildingID = b.BuildingID JOIN VenueEquipment ve ON v.VenueID = ve.VenueID JOIN Equipment e ON ve.EquipmentID = e.EquipmentID GROUP BY v.VenueID;";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvVenue1.DataSource = dt;*/
            //con.Close();
        }

        private void VenueSearchBox1_TextChanged(object sender, EventArgs e)
        {
            /*string searchQuery = VenueSearchBox1.Text;
            LoadData($"SELECT * FROM Building WHERE BuildingName LIKE '%{searchQuery}%'");
            LoadData($"SELECT * FROM Venue WHERE VenueID LIKE '%{searchQuery}%'");
*/

        }

        private void VenueFilterMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* String filter = cbxCategory.SelectedItem.ToString();
            String sql = "SELECT * FROM Venue"; // Venue Directory Does Not Exist
            switch (filter)
            {
                // Filter for Capacity
                case "Capacity : 2-10":
                    sql += " WHERE Capacity > 2 AND Capacity <= 10";
                    break;
                case "Capacity : 11-50":
                    sql += " WHERE Capacity > 10 AND Capacity <= 50";
                    break;
                case "Capacity : 51-100":
                    sql += " WHERE Capacity > 50 AND Capacity <= 100";
                    break;
                case "Capacity : 101-300":
                    sql += " WHERE Capacity > 100 AND Capacity <= 300";
                    break;
                case "Capacity : 300+":
                    sql += " WHERE Capacity > 300";
                    break;

                // Filter fAND Category
                case "Category : THEATRE":
                    sql += " WHERE Category = 'THEATRE' ";
                    break;
                case "Category : TUTORIAL":
                    sql += " WHERE Category = 'TUTORIAL' ";
                    break;
                case "Category : MEETING":
                    sql += " WHERE Category = 'MEETING' ";
                    break;
                case "Category : EXAM":
                    sql += " WHERE Category == 'EXAM' ";
                    break;

                // Filter for Equipment 
                case "Equipment : Projector":
                    sql += " WHERE EquipmentList IN ('Projector') ";
                    break;
                case "Equipment : Microphone":
                    sql += " WHERE EquipmentList IN ('Projector') ";
                    break;
                case "Equipment : Whiteboard":
                    sql += " WHERE EquipmentList IN ('Whiteboard')";
                    break;
                case "Equipment : Speakers":
                    sql += " WHERE EquipmentList IN ('Speakers') ";
                    break;
                case "Equipment : Camera":
                    sql += " WHERE EquipmentList IN ('Camera') ";
                    break;
                case "Equipment : Computer":
                    sql += " WHERE EquipmentList IN ('Computer') ";
                    break;
                case "Equipment : Chairs":
                    sql += " WHERE EquipmentList IN ('Chairs') ";
                    break;
                case "Equipment : Tables":
                    sql += " WHERE EquipmentList IN ('Tables')";
                    break;
                case "Equipment : Television":
                    sql += " WHERE EquipmentList IN ('Televisions')";
                    break;
                case "Equipment : Plugs":
                    sql += " WHERE EquipmentList IN ('Plugs')";
                    break;
                case "Equipment : Airconditioners":
                    sql += " WHERE EquipmentList IN ('AirConditioners') ";
                    break;
            }
            LoadData(sql);*/

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.IconColor = AppColors.AppPurple;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.IconColor = Color.White;
        }

        private void VenueDirectory_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.IconColor = AppColors.AppPurple;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.IconColor = Color.White;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int max = 0;
            int min = 0;

            switch (cbxCapacity.SelectedIndex)
            {
                case 0:
                    max = 10;
                    min = 2; // 2 - 10
                    break;
                case 1:
                    max = 50;
                    min = 11;// 11 - 50
                    break;
                case 2:
                    max = 100;
                    min = 51;// 51 - 100
                    break;
                case 3:
                    max = 300;
                    min = 101;// 101 - 300
                    break;
                case 4:
                    max = int.MaxValue;
                    min = 301;
                    break;
                case 5:
                    max = int.MaxValue;
                    min = int.MinValue;
                    break;
                default:
                    max = 0;
                    min = 10000;
                    break;
            }

            DataTable filterData = dbHelper.FilterVenues(cbxCategory.SelectedItem.ToString(),min,max,cbxEquipment.SelectedItem.ToString());
            dgvVenue.DataSource = filterData;
        }

        private void cbxCapacity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable filterData = dbHelper.FilterVenues("All Venues", int.MinValue, int.MaxValue, "Any Equipment");
            dgvVenue.DataSource = filterData;

        }
    }
}
