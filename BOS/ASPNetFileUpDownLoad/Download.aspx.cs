using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPNetFileUpDownLoad.Utilities;
using System.Data;

namespace ASPNetFileUpDownLoad
{
    public partial class Download : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"]!=null)
            {
                string user = Session["User"].ToString();
                DataTable fileList = FileUtilities.GetFileUser(user);
                gvFiles.DataSource = fileList;
                gvFiles.DataBind();
            }
                
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnRenewal_Click(object sender, EventArgs e)
        {
            Session.Add("Renewal", true);
            Response.Redirect("Subscription.aspx");
        }
    }
}