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
                //Varukorgen visas inte när kunden inte är inloggad
                LiteralCart.Text = "";
            }
            else if (Session["userName"] != null)
            {
                LiteralLogIn.Text = $"<li><a href=\"#\"><span class=\"glyphicon glyphicon-user\"></span> {Session["userName"]}</a></li>";
                //Varukorgen visas bara om kunden är inloggad
                LiteralCart.Text = "<li><a data-toggle=\"modal\" href=\"#modalCart\"><span class=\"glyphicon glyphicon-shopping-cart\"></span> Varukorg</a></li>";

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
            LoadCart();
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


        private void LoadCart()

            //EJ FÄRDIGT (Laddar produkter i modalen för varukorgen)
        {
            List<Product> cart = (List<Product>) Session["Cart"];
            string html = "";
            if (cart == null)
            {
                html += "<div id=\"products\" class=\"row list-group\">";
                html += "<div class=\"item col-xs-4 col-lg-4\">";
                html += "Varukorgen är tom</div>";
                html += "</div>";
                html += "</div>";
                html += "</div>";
                html += "</div>";
                html += "</div>";
            }
            else
            {

                foreach (var product in cart)
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
                    html += "</div>";
                    html += "</div>";
                    html += "</div>";
                    html += "</div>";
                    html += "</div>";
                }
            }

            LiteralCartContent.Text = html;
        }
    }
}