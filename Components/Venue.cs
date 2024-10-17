using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookITFinal.Components
{
    internal class Venue
    {
        public string venueID;
        public string buildingName;
        public int capacity;
        private List<string> equipment = new List<string>();

        private void populateEquipment(string equipment)
        {
            string[] equipmentStrings = equipment.Split(',');
            foreach (string equipmentItem in equipmentStrings)
            {
                this.equipment.Add(equipmentItem);
            }
        }

        public Venue(SQLiteDataReader reader)
        {
            this.venueID = reader["VenueID"].ToString();
            this.buildingName = reader["BuildingName"].ToString();
            this.capacity = Convert.ToInt32(reader["Capacity"].ToString());
            populateEquipment(reader["Equipment"].ToString());
        }

        public bool filter(List<string> equipmentList)
        {
            if (equipmentList.Count > 0) { 
                foreach (string equipmentItem in equipmentList)
                {
                    if (!equipment.Contains(equipmentItem))
                        return false;
                }
            }
            return true;
        }
    }
}
