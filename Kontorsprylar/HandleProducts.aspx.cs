using SQLHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kontorsprylar
{
    public partial class HandleProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // if (Session["adminName"] != null)
            {
                if (!IsPostBack)
                {
                    BindListView();
                }
            }
        }

        private void BindListView()
        {
            List<Product> products = SQL.LoadProducts();
            if (products != null && products.Count() > 0)
            {
                LVCustomers.DataSource = products;
                LVCustomers.DataBind();
            }
        }

        protected void LVCustomers_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                Label lbid = (Label)e.Item.FindControl("lblId");
                int id = Convert.ToInt32(lbid.Text);

                SQL.DeleteProduct(id);
            }
            else if (e.CommandName == "Edit")
            {
                Label lbid = (Label)e.Item.FindControl("lblId");
                int id = Convert.ToInt32(lbid.Text);

                Product tmpProduct = SQL.GetProduct(id);
                TextBoxName.Text = tmpProduct.Name;
                TextBoxPris.Text = tmpProduct.Price.ToString();
                TextBoxDescription.Text = tmpProduct.Description;
                TextBoxPicLink.Text = tmpProduct.PictureLink;
                HiddenFieldID.Value = tmpProduct.PID.ToString();

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalUpdateProduct();", true);
            }
            BindListView();
        }

        protected void LVCustomers_ItemDeleting(object sender, ListViewDeleteEventArgs e)
        {
            // Måste ha den här funktionen annars får jag ett fel. Men vet inte hur jag kan komma åt id-värdet här för att ta bort kunden.
            // Om någon har en bra idé får ni gärna ändra!
        }

        protected void LVCustomers_ItemEditing(object sender, ListViewEditEventArgs e)
        {
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            SQL.UpdateProduct(TextBoxName.Text, Convert.ToDecimal(TextBoxPris.Text), TextBoxDescription.Text, TextBoxPicLink.Text, Convert.ToInt32(HiddenFieldID.Value));
            BindListView();
        }

        protected void ButtonNewProduct_Click(object sender, EventArgs e)
        {
            SQL.AddNewProduct(TextBoxNameNew.Text, Convert.ToDecimal(TextBoxPriceNew.Text), TextBoxDescriptionNew.Text, TextBoxPicLinkNew.Text);
            BindListView();
        }
    }
}