using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookITFinal.Components
{
    internal class Booking
    {
        public string userId;
        public string venueId;
        public string eventType;
        public string date;
        public string startTime;
        public string endTime;

        public Booking(string userId, string venueId, string eventType, string date, string startTime, string endTime) { 
            this.userId = userId;
            this.venueId = venueId;
            this.eventType = eventType;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public Booking(SQLiteDataReader reader)
        {
            this.userId = reader["UserID"].ToString();
            this.venueId = reader["VenueID"].ToString();
            this.eventType = reader["EventType"].ToString();
            this.date = reader["Date"].ToString();
            this.startTime = reader["StartTime"].ToString();
            this.endTime = reader["EndTime"].ToString();
        }

        public bool isTimeConflict(string inputStartTime, string inputEndTime)
        {
            TimeSpan start = TimeSpan.Parse(startTime);
            TimeSpan end = TimeSpan.Parse(endTime);
            TimeSpan plannedStartTime = TimeSpan.Parse(inputStartTime);
            TimeSpan plannedEndTime = TimeSpan.Parse(inputEndTime);

            return (start <= plannedStartTime && end >= plannedStartTime) || (start <= plannedEndTime && end >= plannedEndTime);
        }
    }
}
