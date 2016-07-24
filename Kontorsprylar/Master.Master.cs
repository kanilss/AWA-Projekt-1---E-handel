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
            List<Product> cart = (List<Product>)Session["Cart"];

            string action = Request["action"];
            string product = Request["product"];

            if (action != null && action == "delete" && product != null)
            {
                DeleteProductInCart(Convert.ToInt32(product));
            }

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
                if (cart == null)
                {
                    LiteralCart.Text = $"<li><a data-toggle=\"modal\" href=\"#modalCart\"><span class=\"glyphicon glyphicon-shopping-cart\"></span> Varukorg (0)</a></li>";
                }
                else
                {
                    cart = (List<Product>)Session["Cart"];
                    LiteralCart.Text = $"<li><a data-toggle=\"modal\" href=\"#modalCart\"><span class=\"glyphicon glyphicon-shopping-cart\"></span> Varukorg ({cart.Count})</a></li>";
                }
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
                Session["userID"] = signedInCustomer.ID;
            }
        }


        private void LoadCart()
        //Laddar produkter i modalen för varukorgen
        {
            List<Product> cart = (List<Product>)Session["Cart"];
            string html = "";
            decimal sum = 0;

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
                    html += "<tr>";
                    html += "<td class=\"col-sm-8 col-md-6\">";
                    html += "<div class=\"media\">";
                    html += "<a class=\"thumbnail pull-left\" href=\"#\">";
                    html += $"<img class=\"media-object\" src=\"{product.PictureLink}\" style=\"width: 72px; height: 72px;\">";
                    html += "</a>";
                    html += "<div class=\"media-body\">";
                    html += $"<h4 class=\"media-heading\"><a href=\"#\">{product.Name}</a></h4>";
                    html += "</div>";
                    html += "</div>";
                    html += "</td>";
                    html += "<td class=\"col-sm-1 col-md-1\" style=\"text-align: center\">";
                    html += "<input type=\"email\" class=\"form-control\" id=\"exampleInputEmail1\" value=\"1\">";
                    html += "</td>";
                    html += $"<td class=\"col-sm-1 col-md-1\">{product.Price} kr</td>";
                    html += $"<td class=\"col-sm-1 col-md-1\">{product.Price} kr</td>";
                    html += "<td class=\"col-sm-1 col-md-1\">";
                    html += $"<a class=\"btn btn-danger\" href=\"products.aspx?action=delete&product={product.PID}\"><span class=\"glyphicon glyphicon-remove\"></span>Remove</a>";
                    html += "</td>";
                    html += "</tr>";

                    //Räknar ihop summan för varukorgen
                    sum += product.Price;
                }
            }

            Literal1.Text = html;
            LiteralSum.Text = sum.ToString() + " kr";
        }
        private void DeleteProductInCart(int product)
        {
            List<Product> cart = (List<Product>)Session["Cart"];
            List<Product> resultCart = null;

            if (cart != null)
            {
                resultCart = cart.Where(x => x.PID != product).ToList();
           
            }
            Session["cart"] = resultCart;
            LoadCart();
        }
    }
}