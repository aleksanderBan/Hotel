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

        public Account(string username, string email)
        {
            ID = 0;
            Username = username;
            Email = email;
        }
    }
}
