using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kontorsprylar
{
    abstract public class Account
    {
        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Email
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Password
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string ID
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