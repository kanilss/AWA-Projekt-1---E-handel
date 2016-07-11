using SQLHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kontorsprylar
{
    public partial class RegisterCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                this.Validate();

                if (this.IsValid)
                {
                    SQL.AddNewCustomer(TextBoxName.Text, TextBoxEmail.Text, TextBoxPassword.Text, TextBoxAddress.Text, TextBoxPhone.Text, TextBoxOrgNr.Text);
                }
            }
        }
    }
}