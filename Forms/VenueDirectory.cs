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
            cbxCategory.SelectedIndex = 0;
            cbxEquipment.SelectedIndex = 0;
            cbxCapacity.SelectedIndex = 0;

        }
        public void LoadData(String query)
        {
        }

        private void VenueSearchBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VenueFilterMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnFilter.IconColor = AppColors.AppPurple;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnFilter.IconColor = Color.White;
        }

        private void VenueDirectory_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.IconColor = AppColors.AppPurple;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.IconColor = Color.White;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String Text = VenueSearchBox1.Text;
            DataTable filterData = dbHelper.SearchVenues(Text);
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

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            int max = 0;
            int min = 0;

            switch (cbxCapacity.SelectedIndex)
            {
                case 0:
                    max = int.MaxValue;
                    min = int.MinValue;
                    break;
                case 1:
                    max = 10;
                    min = 2; // 2 - 10
                    break;
                case 2:
                    max = 50;
                    min = 11;// 11 - 50
                    break;
                case 3:
                    max = 100;
                    min = 51;// 51 - 100
                    break;
                case 4:
                    max = 300;
                    min = 101;// 101 - 300
                    break;
                case 5:
                    max = int.MaxValue;
                    min = 301;
                    break;
                
                default:
                    max = 0;
                    min = 10000;
                    break;
            }

            string Equipment;
            if(cbxEquipment.SelectedItem.ToString()== "No Specific Equipment")
            {
                Equipment = "";
            }
            else
            {
                Equipment= cbxEquipment.SelectedItem.ToString();
            }

            DataTable filterData = dbHelper.FilterVenues(cbxCategory.SelectedItem.ToString(), min, max, Equipment); 
            dgvVenue.DataSource = filterData;
        }
    }
}
