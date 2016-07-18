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
                    List<Customer> customers = SQL.LoadCustomers();
                    if (customers != null && customers.Count() > 0)
                    {
                        GridView1.DataSource = customers;
                        GridView1.DataBind();
                    }
                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = GridView1.Rows[e.RowIndex].Cells[0];
            int id = Convert.ToInt32(cell.Text);

            SQL.DeleteCustomer(id);
            GridView1.DataBind();
        }
    }
}