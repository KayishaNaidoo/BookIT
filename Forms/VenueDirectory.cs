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
       
        public VenueDirectory()
        {
            InitializeComponent();
            
        }

        private void VenueDirectory_Load(object sender, EventArgs e)
        {
            cbxCategory.SelectedIndex = 0;
            cbxEquipment.SelectedIndex = 0;
            cbxCapacity.SelectedIndex = 0;
        }

        private void VenueSearchBox1_TextChanged(object sender, EventArgs e)
        {
            FilterandSearch();
        }

        private void VenueFilterMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterandSearch();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
           
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
            FilterandSearch();

        }

        private void cbxCapacity_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterandSearch();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            VenueSearchBox1.Clear();
            cbxCategory.SelectedIndex = 0;
            cbxEquipment.SelectedIndex = 0;
            cbxCapacity.SelectedIndex = 0;
            VenueSearchBox1.Focus();

        }

        void FilterandSearch()
        {
            String Text = VenueSearchBox1.Text;
           
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
           
            if (cbxEquipment.SelectedItem == null || cbxEquipment.SelectedItem.ToString() == "No Specific Equipment")
            {
                Equipment = "";
            }
            else
            {
                Equipment = cbxEquipment.SelectedItem.ToString();
            }


            DataTable filterData = dbHelper.SearchAndFilterVenues(Text,cbxCategory.SelectedItem.ToString(), min, max, Equipment);
            dgvVenue.DataSource = filterData;
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
          
        }

        private void cbxEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterandSearch();
        }
    }
}
