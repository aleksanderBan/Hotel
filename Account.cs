using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Account
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public Account(int id, string username, string email)
        {
            ID = id;
            Username = username;
            Email = email;
        }
    }
}
