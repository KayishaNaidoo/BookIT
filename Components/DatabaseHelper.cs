using BookITFinal.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

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
                ExecuteQuery("SELECT * FROM Users");

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
                    SQLiteDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        userType = reader["UserType"].ToString();
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
                    SQLiteDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Console.WriteLine(dataReader.GetString(1));
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


        public void CreateUser(string userID, string firstName, string lastName, string email, string contactNo, string password, string UserType)
        {
           
            string query = $"INSERT INTO Users (UserID, FirstName, LastName, Email, ContactNo, Password, UserType) " +
                           $"VALUES ('{userID}', '{firstName}', '{lastName}', '{email}', '{contactNo}', '{password}', '{UserType}')";

            ExecuteQuery(query); 
            CloseConnection();
        }

        public DataTable GetBookings(String UserID)
        {
            DataTable bookingsTable = new DataTable();

            try
            {
                string query = "SELECT EventType AS [Event Type],Date, Booking.VenueID AS [Venue], BuildingName AS [Building], StartTime AS [Start Time], EndTime AS [End time] " +
                    "FROM Booking JOIN Venue ON Booking.VenueID=Venue.VenueID "+
                    "JOIN Building ON Venue.BuildingID= Building.BuildingID " +
                    $"WHERE Booking.UserID='{UserID}';";
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(bookingsTable); // Fill the DataTable with data from the query
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching bookings: {ex.Message}");
            }

            return bookingsTable;
        }


        private void CloseConnection()
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
                Console.WriteLine("Connection closed.");
            }
        }
    }
}
