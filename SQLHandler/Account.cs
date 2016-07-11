using System;
using System.Web;
using System.ComponentModel;

namespace SQLHandler
{
    abstract public class Account
    {
        public Account(string name, string email, string password, int id)
        {
            Name = name;
            Email = email;
            Password = password;
            ID = id;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int ID { get; set; }

    }
}