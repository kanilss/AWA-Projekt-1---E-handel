using SQLHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kontorsprylar
{
    public partial class CustomerHandleAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["userEmail"] != null && Session["password"] != null)
                {
                    string emailSignedInCustomer = Session["userEmail"].ToString();
                    string passwordSignedInCustomer = Session["password"].ToString();

                    try
                    {
                        //Hämtar kunden som är inloggad
                        Customer tmpCustomer = SQL.GetCustomer(emailSignedInCustomer, passwordSignedInCustomer);

                        HiddenFieldID.Value = tmpCustomer.ID.ToString();

                        TextBoxName.Text = tmpCustomer.Name;
                        TextBoxEmail.Text = tmpCustomer.Email;
                        TextBoxAddress.Text = tmpCustomer.Address;
                        TextBoxPhone.Text = tmpCustomer.Phone;
                        TextBoxOrgNr.Text = tmpCustomer.OrgNr;
                    }
                    catch (Exception)
                    {
                        TextBoxName.Text = "Du måste logga in";
                    }
                }
            }
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            //Kollar så att rätt lösenord är ifyllt
            Customer tmpCustomer = SQL.GetCustomer(Session["userEmail"].ToString(), TextBoxPassword.Text);

            if (tmpCustomer != null)
            {
                // Uppdaterar kunden med de nya värderna 
                SQL.UpdateCustomer(TextBoxName.Text, TextBoxEmail.Text, TextBoxAddress.Text, TextBoxPhone.Text, TextBoxOrgNr.Text, Convert.ToInt32(HiddenFieldID.Value));
                // Ifall email-adressen uppdaterats sparas den nya mailadressen i session
                Session["userEmail"] = TextBoxEmail.Text;
            }
        }

        protected void ButtonUpdatePassword_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openmodalUpdatePassword();", true);

        }

        protected void LBUpdatePsw_Click(object sender, EventArgs e)
        {
            Customer tmpCustomer = SQL.GetCustomer(Session["userEmail"].ToString(), TextBoxOldPswd.Text);
            if (tmpCustomer!=null && TextBoxNewPswd.Text == TextBoxConfirmNewPswd.Text)
            {
                SQL.UpdateCustomer(TextBoxNewPswd.Text, tmpCustomer.ID);
            }
        }
    }
}