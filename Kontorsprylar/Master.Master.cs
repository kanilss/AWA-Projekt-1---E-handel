using SQLHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kontorsprylar
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                RFVLoginEmail.Validate();
                RFVLoginPassword.Validate();

                if (RFVLoginEmail.IsValid && RFVLoginPassword.IsValid)
                {
                    TrySignInUser(TextBoxLoginEmail.Text, TextBoxLoginPassword.Text);
                }
            }

            //Om ingen är inloggad. Visa upp "logga in" som leder till inloggningsmodal. 
            if (Session["userName"] == null)
            {
                LiteralLogIn.Text = "<li><a data-toggle=\"modal\" href=\"#modalSignIn\"><span class=\"glyphicon glyphicon-user\"></span> Logga in</a></li>";
            }
            else if (Session["userName"] != null)
            {
                LiteralLogIn.Text = $"<li><a href=\"#\"><span class=\"glyphicon glyphicon-user\"></span> {Session["userName"]}</a></li>";

                //TODO: Om inloggad. Visa upp länk till typ "hantera konto"
            }
        }

        private void TrySignInUser(string email, string password)
        {
            Customer signedInCustomer = SQL.GetCustomer(email, password);
           
            if (signedInCustomer != null)
            {
                Session["userName"] = signedInCustomer.Name;
            }
        }
    }
}