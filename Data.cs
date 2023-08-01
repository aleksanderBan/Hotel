using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Hotel
{
    //Connecting to the database
    public class Data
    {
        private string ConnectionString =
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

        //Insert an account into the database
        public int AccountDB(Account account)
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
    }
}