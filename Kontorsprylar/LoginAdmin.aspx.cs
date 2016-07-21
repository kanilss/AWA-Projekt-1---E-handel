using SQLHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kontorsprylar
{
    public partial class LoginAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                RFVLoginEmail.Validate();
                RFVLoginPassword.Validate();

                if (RFVLoginEmail.IsValid && RFVLoginPassword.IsValid)
                {
                    TrySignInAdmin(TextBoxLoginEmail.Text, TextBoxLoginPassword.Text);
                }
            }
        }
        private void TrySignInAdmin(string email, string password)
        {
            Admin signedInAdmin = SQL.GetAdmin(email, password);

            if (signedInAdmin != null)
            {
                Session["adminName"] = signedInAdmin.Name;
            }
        }
    }
}