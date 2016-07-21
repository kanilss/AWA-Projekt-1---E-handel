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

            //Om ingen kund är inloggad. Visa upp "logga in" som leder till inloggningsmodal. 
            if (Session["userName"] == null)
            {
                LiteralLogIn.Text = "<li><a data-toggle=\"modal\" href=\"#modalSignIn\"><span class=\"glyphicon glyphicon-user\"></span> Logga in</a></li>";
            }
            else if (Session["userName"] != null)
            {
                LiteralLogIn.Text = $"<li><a href=\"CustomerHandleAccount.aspx\"><span class=\"glyphicon glyphicon-user\"></span> {Session["userName"]}</a></li>";
                //TODO: Om inloggad. Visa upp länk till typ "hantera konto"
            }

            //Kolla om administratör är inloggad    
            if (Session["adminName"] == null)
            {
                LiteralAdmin.Text = "<span style=\"float:right;\"><a href=\"LoginAdmin.aspx\">Logga in som administratör</a></span>";
            }
            else if (Session["adminName"] != null)
            {
                string html = "";
                html += "<span style=\"float:right;\"><a href=\"HandleProducts.aspx\">Hantera produkter</a></span></br>";
                html += "<span style=\"float:right;\"><a href=\"HandleCustomers.aspx\">Hantera kunder</a></span>";
                LiteralAdmin.Text = html;
            }
        }

        private void TrySignInUser(string email, string password)
        {
            Customer signedInCustomer = SQL.GetCustomer(email, password);

            if (signedInCustomer != null)
            {
                Session["userName"] = signedInCustomer.Name;
                Session["userEmail"] = email;
                Session["password"] = password;
            }
        }


        private void LoadChart()

            //EJ FÄRDIGT (Laddar produkter i modalen för varukorgen)
        {
            List<Product> chart = (List<Product>) Session["Chart"];
            string html = "";
            foreach (var product in chart)
            {
                html += "<div id=\"products\" class=\"row list-group\">";
                html += "<div class=\"item col-xs-4 col-lg-4\">";
                html += $"<div class=\"thumbnail\">";
                html += $"<img class=\"group list-group-image\" src=\"http://placehold.it/400x250/000/fff\" alt=\"\"/>";
                html += $"<div class=\"caption\">";
                html += $"<h4 class=\"group inner list-group-item-heading\">";
                html += $"{product.Name}</h4>";
                html += $"<p class=\"group inner list-group-item-text\">";
                html += $"{product.Description}</p>";
                html += $"<div class=\"row\">";
                html += $"<div class=\"col-xs-12 col-md-6\">";
                html += $"<p class=\"lead\">";
                html += $"{product.Price} kr</p>";
                html += $"</div>";
                html += $"<div class=\"col-xs-12 col-md-6\">";
                html += $"<a class=\"btn btn-success\" href=\"products.aspx?action=add&product={product.PID}\">Lägg till i varukorg</a>";
                html += "</div>";
                html += "</div>";
                html += "</div>";
                html += "</div>";
                html += "</div>";
                html += "</div>";
            }

            LiteralChart.Text = html;
        }
    }
}