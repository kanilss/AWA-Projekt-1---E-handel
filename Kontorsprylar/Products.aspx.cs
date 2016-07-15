using SQLHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kontorsprylar
{
    public partial class Products : System.Web.UI.Page
    {
        List<Product> products = SQL.LoadProducts();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string action = Request["action"];
                string product = Request["product"];

                if (action != null && product != null)
                {
                    try
                    {
                        //Add product to shoppingcart

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            LoadProducts();
        }

        private void LoadProducts()
        {
            string html = "";
            foreach (var product in products)
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

            LiteralProducts.Text = html;
        }
    }
}