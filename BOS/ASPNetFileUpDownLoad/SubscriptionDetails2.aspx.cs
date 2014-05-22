using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetFileUpDownLoad
{
    public partial class SubscriptionDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Subscription.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}