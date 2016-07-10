using System;
using System.Web;
using System.ComponentModel;

namespace SQLHandler
{
    public class Product
    {
        public Product(string name, int price, int pid, string description)
        {
            Name = name;
            Price = price;
            PID = pid;
            Description = description;
        }

        public string Name { get; set; }
        public int Price { get; set; }
        public int PID { get; set; }
        public string Description { get; set; }
    }
}