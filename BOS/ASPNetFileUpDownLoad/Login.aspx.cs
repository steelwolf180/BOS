using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPNetFileUpDownLoad.Utilities;

namespace ASPNetFileUpDownLoad
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {            
            string user = txtUsername.Text;
            string password = txtPassword.Text;
            int type = 0;

            FileUtilities.Authentication(user, password,ref type);

            if (type == 0)
            {
                Session["User"] = user;
                Response.Redirect("Default.aspx");
            }
            else if (type == 1)
            {
                Session["User"] = user;
                Response.Redirect("Download.aspx");
            }
            else
            {
                lblError.Text = "Error: You have entered the wrong username and password please try again";
            }
        }

        protected void btnRecovery_Click(object sender, EventArgs e)
        {
            Response.Redirect("PasswordRecovery.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

    }
}