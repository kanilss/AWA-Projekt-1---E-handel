using SQLHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kontorsprylar
{
    public partial class RegisterCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // Får det inte att fungera med this.Validate() och this.IsValid
                RFVName.Validate();
                RFVEmail.Validate();
                RFVAddress.Validate();
                RFVPhone.Validate();
                RFVOrgNr.Validate();
                RFVPassword.Validate();
                CVConfirm.Validate();


                if (RFVName.IsValid && RFVEmail.IsValid && RFVAddress.IsValid &&RFVPhone.IsValid && RFVOrgNr.IsValid && RFVPassword.IsValid && CVConfirm.IsValid)
                {
                    SQL.AddNewCustomer(TextBoxName.Text, TextBoxEmail.Text, TextBoxPassword.Text, TextBoxAddress.Text, TextBoxPhone.Text, TextBoxOrgNr.Text);
                }
            }
        }
    }
}