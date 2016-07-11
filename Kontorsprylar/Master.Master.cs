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
            if(IsPostBack)
            {
               //TODO: Jämföra användarnamn och lösenord med SQL-databas. Spara i Session["userid"]
            }

            //Om ingen är inloggad. Visa upp "logga in" som leder till inloggningsmodal. 
            if(Session["userid"] == null)
                LiteralLogIn.Text = "<li><a data-toggle=\"modal\" href=\"#modalSignIn\"><span class=\"glyphicon glyphicon-user\"></span> Logga in</a></li>";
            //TODO: Om inloggad. Visa upp länk till typ "hantera konto"

        }
    }
}