using System;
using System.Web;
using System.ComponentModel;
using System.Collections.Generic;

namespace SQLHandler
{
    public class Order
    {
        public Order(int oid, int cid, int totalPrice)
        {
            OID = oid;
            CID = cid;
            TotalPrice = totalPrice;
            Products = new List<Product>();
        }

        public int OID { get; set; }
        public int TotalPrice { get; set; }
        public int CID { get; set; }
        public List<Product> Products { get; set; }
    }
}