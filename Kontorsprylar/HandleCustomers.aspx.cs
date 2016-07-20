using SQLHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kontorsprylar
{
    public partial class HandelCustomers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminName"] != null)
            {
                if (!IsPostBack)
                {
                    BindListView();
                }
            }
        }

        private void BindListView()
        {
            List<Customer> customers = SQL.LoadCustomers();
            if (customers != null && customers.Count() > 0)
            {
                LVCustomers.DataSource = customers;
                LVCustomers.DataBind();
            }
        }

        protected void LVCustomers_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                Label lbid = (Label)e.Item.FindControl("lblId");
                int id = Convert.ToInt32(lbid.Text);
                
                SQL.DeleteCustomer(id);                    
            }
            else if(e.CommandName == "Edit")
            {
                Label lbid = (Label)e.Item.FindControl("lblId");
                int id = Convert.ToInt32(lbid.Text);

                Customer tmpCustomer = SQL.GetCustomer(id);
                TextBoxName.Text = tmpCustomer.Name;
                TextBoxEmail.Text = tmpCustomer.Email;
                TextBoxAddress.Text = tmpCustomer.Address;
                TextBoxPhone.Text = tmpCustomer.Phone;
                TextBoxOrgNr.Text = tmpCustomer.OrgNr;
                HiddenFieldID.Value = tmpCustomer.ID.ToString();

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalUpdateCustomer();", true);
            }
            else if(e.CommandName == "OrderHistory")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalOrderHistory();", true);
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
            SQL.UpdateCustomer(TextBoxName.Text, TextBoxEmail.Text, TextBoxAddress.Text, TextBoxPhone.Text, TextBoxOrgNr.Text, Convert.ToInt32(HiddenFieldID.Value));
            BindListView();
        }
    }
}