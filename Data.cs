using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using MySqlConnector;

namespace Hotel
{
    //Connecting to the database
    public class Data
    {
        private static string ConnectionString =
            "datasource=localhost;" +
            "port=3306;" +
            "username=root;" +
            "password=root;" +
            "database=hotel_db;";

        private MySqlConnection Connection { get; set; }

        public Data()
        {
            Connection = new MySqlConnection(ConnectionString);

            try
            {
                Connection.Open();
                Console.WriteLine("Database connection successful.");
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database connection failed: " + ex.Message);
            }
        }

        //Database operations

        //Insert an account into the database
        public int DBInsertAccount(Account account)
        {
            string query = $"INSERT INTO account (username, email) " +
                   $"VALUES ('{account.Username}', '{account.Email}');";

            int accountId = -1;

            try
            {
                Connection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(query, Connection);
                commandDatabase.ExecuteNonQuery();
                accountId = (int)commandDatabase.LastInsertedId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return accountId;
        }

        //Check if email is in the database from the Login form
        public bool DBCheckEmail(string email)
        {
            string query = $"SELECT COUNT(*) FROM account WHERE email = @email";

            try
            {
                Connection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(query, Connection);
                commandDatabase.Parameters.AddWithValue("@email", email);
                long result = (long)commandDatabase.ExecuteScalar();
                Connection.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return false;
        }

        //Find dates in between input dates
        private List<DateTime> GetDatesInRange(DateTime startDate, DateTime endDate)
        {
            List<DateTime> allDatesInRange = new List<DateTime>();
            DateTime currentDate = startDate;
            while (currentDate <= endDate)
            {
                allDatesInRange.Add(currentDate);
                currentDate = currentDate.AddDays(1);
            }
            return allDatesInRange;
        }

        //Find available rooms in the DB
        public List<(string RoomID, string RoomInfo)> DBFindRooms(string startDateStr, string endDateStr, string selectedRoomType)
        {
            List<(string RoomId, string RoomInfo)> availableRooms = new List<(string, string)>();

            DateTime startDate, endDate;
            if (DateTime.TryParse(startDateStr, out startDate) && DateTime.TryParse(endDateStr, out endDate))
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT id, type, datefrom, dateuntil, info FROM rooms WHERE (@startDate BETWEEN datefrom AND dateuntil OR @endDate BETWEEN datefrom AND dateuntil OR (datefrom BETWEEN @startDate AND @endDate AND dateuntil BETWEEN @startDate AND @endDate)) AND type = @roomType";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    command.Parameters.AddWithValue("@roomType", selectedRoomType);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string roomId = reader["id"].ToString();
                            string roomInfo = reader["info"].ToString();
                            availableRooms.Add((roomId, roomInfo));
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid date format provided.");
            }

            return availableRooms;
        }

        //Get username from email from the DB
        public string DBGetAccountUsername(string email)
        {
            string query = "SELECT username FROM account WHERE email = @email";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", email);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        //Booked room insertion into the DB
        public bool DBInsertBooking(string username, string arrivalDate, string departureDate, string roomId)
        {
            string query = "INSERT INTO booking (name, doa, dol, roomid) VALUES (@name, @doa, @dol, @roomid)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", username);
                        command.Parameters.AddWithValue("@doa", DateTime.Parse(arrivalDate));
                        command.Parameters.AddWithValue("@dol", DateTime.Parse(departureDate));
                        command.Parameters.AddWithValue("@roomid", roomId);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Booking history
        public List<string> DBGetBookingHistory(string username)
        {
            List<string> bookingHistory = new List<string>();

            string query = "SELECT id, doa, dol FROM booking WHERE name = @username";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bookingId = reader["id"].ToString();
                            string arrivalDate = reader["doa"].ToString();
                            string departureDate = reader["dol"].ToString();
                            string bookingDetails = $"Booking ID: {bookingId}, Arrival: {arrivalDate}, Departure: {departureDate}";
                            bookingHistory.Add(bookingDetails);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return bookingHistory;
        }

        //Remove bookings
        public bool DBRemoveBooking(int bookingId)
        {
            string query = "DELETE FROM booking WHERE id = @bookingId";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@bookingId", bookingId);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0; // Return true if rows were affected (booking removed)
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false; // Return false if an error occurred
            }
        }

        //Get information about rooms
        public List<string> DBGetRoomInformation()
        {
            List<string> roomInfoList = new List<string>();

            string query = "SELECT id, type, datefrom, dateuntil FROM rooms";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string roomId = reader["id"].ToString();
                            string roomType = reader["type"].ToString();
                            string dateFrom = reader["datefrom"].ToString();
                            string dateUntil = reader["dateuntil"].ToString();

                            // Construct the room information string with "datefrom" and "dateuntil" values
                            string roomInfo = $"ID: {roomId}, Type: {roomType}, Available From: {dateFrom} Until: {dateUntil}";
                            roomInfoList.Add(roomInfo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return roomInfoList;
        }

        //Get current room date
        public string DBGetCurrentDateForRoom(int roomId)
        {
            string query = "SELECT datefrom FROM rooms WHERE id = @roomId";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@roomId", roomId);

                try
                {
                    connection.Open();
                    var currentDate = command.ExecuteScalar();
                    if (currentDate != null && currentDate != DBNull.Value)
                    {
                        DateTime date = Convert.ToDateTime(currentDate);
                        return date.ToString("yyyy-MM-dd");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return "N/A";
        }

        //Update room date
        public bool DBUpdateRoomDate(int roomId, string newDateFrom, string newDateUntil)
        {
            string query = "UPDATE rooms SET datefrom = @newDateFrom, dateuntil = @newDateUntil WHERE id = @roomId";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@newDateFrom", newDateFrom);
                command.Parameters.AddWithValue("@newDateUntil", newDateUntil);
                command.Parameters.AddWithValue("@roomId", roomId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        //Get bookings for Admin
        public List<string> DBGetBookingsAdmin()
        {
            List<string> bookingsAdmin = new List<string>();

            string query = "SELECT id, doa, dol FROM booking";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                
                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bookingId = reader["id"].ToString();
                            string arrivalDate = reader["doa"].ToString();
                            string departureDate = reader["dol"].ToString();
                            string bookingDetails = $"Booking ID: {bookingId}, Arrival: {arrivalDate}, Departure: {departureDate}";
                            bookingsAdmin.Add(bookingDetails);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return bookingsAdmin;
        }

        //Dates from and until
        public string DBGetDateFromForRoom(int roomId)
        {
            string query = "SELECT datefrom FROM rooms WHERE id = @roomId";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@roomId", roomId);

                try
                {
                    connection.Open();
                    var dateFrom = command.ExecuteScalar();
                    if (dateFrom != null && dateFrom != DBNull.Value)
                    {
                        DateTime fromDate = Convert.ToDateTime(dateFrom);
                        return fromDate.ToString("yyyy-MM-dd");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return "N/A";
        }
        public string DBGetDateUntilForRoom(int roomId)
        {
            string query = "SELECT dateuntil FROM rooms WHERE id = @roomId";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@roomId", roomId);

                try
                {
                    connection.Open();
                    var dateUntil = command.ExecuteScalar();
                    if (dateUntil != null && dateUntil != DBNull.Value)
                    {
                        DateTime untilDate = Convert.ToDateTime(dateUntil);
                        return untilDate.ToString("yyyy-MM-dd");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return "N/A";
        }

        // Insert a room into the database
        public bool DBAddRoomAdmin(string roomType, string dateFrom, string dateUntil, string roomInfo)
        {
            string query = "INSERT INTO rooms (type, datefrom, dateuntil, info) VALUES (@type, @dateFrom, @dateUntil, @info)";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@type", roomType);
                command.Parameters.AddWithValue("@dateFrom", dateFrom);
                command.Parameters.AddWithValue("@dateUntil", dateUntil);
                command.Parameters.AddWithValue("@info", roomInfo);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        // Extract booking ID from booking details
        public int ExtractBookingId(string bookingDetails)
        {
            // Find the index of "Booking ID:" and extract the substring after it
            int idIndex = bookingDetails.IndexOf("Booking ID:") + 11;
            int commaIndex = bookingDetails.IndexOf(",", idIndex);
            string idSubstring = bookingDetails.Substring(idIndex, commaIndex - idIndex);

            // Convert the extracted substring to an integer
            if (int.TryParse(idSubstring.Trim(), out int bookingId))
            {
                return bookingId;
            }

            // Return -1 if extraction fails
            return -1;
        }

    }
}