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
        public List<(string RoomID, string RoomInfo)> DBFindRooms(string startDateStr, string endDateStr)
        {
            List<(string RoomId, string RoomInfo)> availableRooms = new List<(string, string)>();

            DateTime startDate, endDate;
            if (DateTime.TryParse(startDateStr, out startDate) && DateTime.TryParse(endDateStr, out endDate))
            {
                List<DateTime> allDatesInRange = GetDatesInRange(startDate, endDate);

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    foreach (DateTime date in allDatesInRange)
                    {
                        string query = "SELECT id, type, date, info FROM rooms WHERE date = @date";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@date", date);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string roomId = reader["id"].ToString();
                                //string roomType = reader["type"].ToString();
                                //string roomDate = reader["date"].ToString();
                                string roomInfo = reader["info"].ToString();
                                availableRooms.Add((roomId, roomInfo));
                            }
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
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", username);
                    command.Parameters.AddWithValue("@doa", DateTime.Parse(arrivalDate));
                    command.Parameters.AddWithValue("@dol", DateTime.Parse(departureDate));
                    command.Parameters.AddWithValue("@roomid", roomId);

                    connection.Open();
                    if(command.ExecuteNonQuery()>0) return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}