using BookITFinal.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Controls.Primitives;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Collections.Generic;
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BookITFinal.Components
{
    internal class DatabaseHelper
    {
        private SQLiteConnection con;

        public DatabaseHelper()
        {
            string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Components", "Bookit.db");

            con = new SQLiteConnection($"Data Source={databasePath}");

            try
            {
                con.Open();
                Console.WriteLine("DB connection successful");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"DB connection failed: {ex.Message}");
            }
        }

        public string GetUserType(string userID)
        {
            string userType = string.Empty;

            try
            { 
                string query = "SELECT UserType FROM Users WHERE UserID = @UserID";
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    // Use parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@UserID", userID);                   
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userType = reader["UserType"].ToString();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching user type: {ex.Message}");
            }

            return userType; 
        }


        public void ExecuteQuery(string query)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Console.WriteLine(dataReader.GetString(1));
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query execution failed: {ex.Message}");
            
            }
        }

        public bool Login(string userID, string password)
        {
            bool isAuthenticated = false;

            try
            {
      
                string query = $"SELECT COUNT(*) FROM Users WHERE UserID = @UserID AND Password = @Password";

                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    // Use parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Password", password);

                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    // If userCount>0, the credentials valid
                    if (userCount > 0)
                    {
                        isAuthenticated = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during login: {ex.Message}");
            }

            return isAuthenticated;
        }

        //@Colby and liam please try to make cases or something in case a user tries to create an account with a userID that is alredy in the table
        public void CreateUser(string userID, string firstName, string lastName, string email, string contactNo, string password, string UserType)
        {
           
            string query = $"INSERT INTO Users (UserID, FirstName, LastName, Email, ContactNo, Password, UserType) " +
                           $"VALUES ('{userID}', '{firstName}', '{lastName}', '{email}', '{contactNo}', '{password}', '{UserType}')";

             try { 
                ExecuteQuery(query);
                MessageBox.Show("Sign Up Sucessful");
            }
            catch
            {
                MessageBox.Show("Sign Up Unsucessful due to unknown erros.");
            }
      
        }

       

        public DataTable GetBookings(String UserID)
        {
            DataTable bookingsTable = new DataTable();

            try
            {
                string query = "SELECT EventType AS [Event Type],Date, Booking.VenueID AS [Venue], StartTime AS [Start Time], EndTime AS [End time] " +
                    "FROM Booking JOIN Venue ON Booking.VenueID=Venue.VenueID "+
                    "JOIN Building ON Venue.BuildingID= Building.BuildingID " +
                    $"WHERE Booking.UserID='{UserID}';";
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(bookingsTable); 
                    }
                }

          
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching bookings: {ex.Message}");
            }

            return bookingsTable;
        }

   

        public DataTable GetChart(string UserId)
        {
            DataTable bookingsTable = new DataTable();

            try
            {
                string query = "SELECT VenueID, COUNT(DISTINCT BookingID) FROM Booking " +
                                $"WHERE UserID = '{UserId}' " +
                                "GROUP BY VenueID " +
                                "ORDER BY COUNT(DISTINCT BookingID) DESC " +
                                "LIMIT 5; ";
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(bookingsTable);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching bookings: {ex.Message}");
            }

            return bookingsTable;
        }

        public string[] GetUserDetails(string UserID)
        {
            string[] userDetails = new string[4];

            try
            {
                string query = "SELECT FirstName, LastName, Email, ContactNo " +
                               $"FROM Users WHERE UserID = '{UserID}';";

                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userDetails[0] = reader["FirstName"].ToString();
                            userDetails[1] = reader["LastName"].ToString();
                            userDetails[2] = reader["Email"].ToString();
                            userDetails[3] = reader["ContactNo"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching user details: {ex.Message}");
            }

            return userDetails;
        }


        public void EditFName(string UserId, string newFName)
        {
            string query = $"UPDATE Users SET FirstName = '{newFName}' WHERE UserID = '{UserId}'";
            ExecuteQuery(query);   
        }

        public void EditLName(string UserId, string newLName)
        {
            string query = $"UPDATE Users SET LastName = '{newLName}' WHERE UserID = '{UserId}'";
            ExecuteQuery(query);
        }



        public string[] GetVenues(int minCapacity, int maxCapacity)
        {
            List<string> results = new List<string>();

            try
            {
                string query = "SELECT Venue.VenueID, Building.BuildingName" +
                    " FROM Venue JOIN Building ON Venue.BuildingID = Building.BuildingID " +
                    $"WHERE Venue.Capacity BETWEEN {minCapacity} AND {maxCapacity} ;";

                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            // Combine VenueID and BuildingName into a single string
                            string venueInfo = $"{reader["VenueID"]} - {reader["BuildingName"]}";
                            results.Add(venueInfo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching venues: {ex.Message}");
            }

            // Convert the List to a normal array
            return results.ToArray();
        }




        public void CloseConnection()
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
                Console.WriteLine("Connection closed.");
            }
        }
    }
}
