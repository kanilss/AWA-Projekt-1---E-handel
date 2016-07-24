using SQLHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kontorsprylar
{
	public partial class CheckOut : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            LoadCart();
		}

        private void LoadCart()
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

                    html += "<div class=\"form-group\">";
                    html += "<div class=\"col-sm-3 col-xs-3\">";
                    html += $"<img class=\"img-responsive\" src=\"{product.PictureLink}\"/>";
                    html += "</div>";
                    html += "<div class=\"col-sm-6 col-xs-6\">";
                    html += $"<div class=\"col-xs-12\">{product.Name}</div>";
                    html += "</div>";   
                    html += "<div class=\"col-sm-3 col-xs-3 text-right\">";
                    html += $"<h6><span>$</span>{product.Price}</h6>";
                    html += "</div>";
                    html += "</div>";
                    html += "<div class=\"form-group\"><hr/></div>";

                    //Räknar ihop summan för varukorgen
                    sum += product.Price;
                }
            }

            Literal1.Text = html;
            LiteralSum.Text = sum.ToString() + " kr";
        }
    }
}