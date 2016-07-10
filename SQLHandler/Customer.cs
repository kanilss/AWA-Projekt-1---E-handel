using System;
using System.Web;
using System.ComponentModel;
using System.Collections.Generic;

namespace SQLHandler
{
    public class Customer : Account
    {
        public Customer(string name, string email, string password, int id, string address, string phone, string orgNr) : base(name, email, password, id)
        {
            Address = address;
            Phone = phone;
            OrgNr = orgNr;
            OrderHistory = new List<Order>();
        }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string OrgNr { get; set; }
        public List<Order> OrderHistory { get; set; }
    }
}