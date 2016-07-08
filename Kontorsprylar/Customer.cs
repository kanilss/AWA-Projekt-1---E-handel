using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kontorsprylar
{
    public class Customer : Account
    {
        public string Address
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Phone
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Orgnr
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<Order> OrderHistory
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}