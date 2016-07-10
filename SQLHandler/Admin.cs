using System;
using System.Web;
using System.ComponentModel;

namespace SQLHandler
{
    public class Admin : Account
    {
        public Admin(string name, string email, string password, int id) : base(name, email, password, id)
        {

        }
    }
}