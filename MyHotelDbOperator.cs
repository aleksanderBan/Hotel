using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class MyHotelDbOperator
    {
        private MyHotelDb myHotelDb;

        public MyHotelDbOperator() {
            myHotelDb = new MyHotelDb();
        }

    //Insert an account into the database
    public int AccountDB(Account account)
    {
        string query = $"INSERT INTO account (username, email) " +
               $"VALUES ('{account.Username}', '{account.Email}');";

        int accountId = -1;
            MyHotelDb db = new MyHotelDb();
            try
        {
            db.Connection.Open();
            MySqlCommand commandDatabase = new MySqlCommand(query,myHotelDb.Connection);
            commandDatabase.ExecuteNonQuery();
            accountId = (int)commandDatabase.LastInsertedId;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            db.Connection.Close();
        }

        return accountId;
    }

    //Check if email is in the database from the Login form
    public bool EmailDB(string email)
    {
        string query = $"SELECT COUNT(*) FROM account WHERE email = @email";
            
            try
        {
                MyHotelDb db = new MyHotelDb();
                db.Connection.Open();
            MySqlCommand commandDatabase = new MySqlCommand(query, myHotelDb.Connection);
            commandDatabase.Parameters.AddWithValue("@email", email);
            long result = (long)commandDatabase.ExecuteScalar();
            db.Connection.Close();
            return result > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            myHotelDb.Connection.Close();
        }

        return false;
    }

    //Find available rooms in the DB
    public List<(string RoomID, string RoomInfo)> AvailableRoomsDB(string startDateStr, string endDateStr)
    {
        List<(string RoomId, string RoomInfo)> availableRooms = new List<(string, string)>();

        DateTime startDate, endDate;
        if (DateTime.TryParse(startDateStr, out startDate) && DateTime.TryParse(endDateStr, out endDate))
        {
            List<DateTime> allDatesInRange = GetDatesInRange(startDate, endDate);
                MyHotelDb db = new MyHotelDb();
                using (MySqlConnection connection =db.Connection)
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
                            string roomType = reader["type"].ToString();
                            string roomDate = reader["date"].ToString();
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

    //Get username from email from the DB
    public string GetUsernameByEmail(string email)
    {
        string query = "SELECT username FROM account WHERE email = @email";

        try
        {
                MyHotelDb db = new MyHotelDb();
                using (MySqlConnection connection = db.Connection)
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
    public bool BookedRoomDB(string username, string arrivalDate, string departureDate, string roomId)
    {
        string query = "INSERT INTO booking (name, doa, dol, roomid) VALUES (@name, @doa, @dol, @roomid)";

        try
        {
                MyHotelDb db = new MyHotelDb();
            using (MySqlConnection connection = db.Connection)
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", username);
                command.Parameters.AddWithValue("@doa", DateTime.Parse(arrivalDate));
                command.Parameters.AddWithValue("@dol", DateTime.Parse(departureDate));
                command.Parameters.AddWithValue("@roomid", roomId);

                connection.Open();
                if (command.ExecuteNonQuery() > 0) return true;

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
