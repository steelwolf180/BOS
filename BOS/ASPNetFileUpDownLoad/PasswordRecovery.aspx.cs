using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetFileUpDownLoad
{
    public partial class PasswordRecovery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            bool opt = false, opt1 = false;

            string user = txtUser.Text, email = txtEmail.Text;
            try
            {
                if (user.Length != 0)
                {
                    //check and send by email
                    Utilities.FileUtilities.CheckAccountByUser(user);
                    lblError.Text = "A Email has been send";
                    opt = true;
                }                
                else if (email.Length != 0)
                {
                     //check and send by email
                    Utilities.FileUtilities.CheckAccountByEmail(email);
                    lblError.Text = "A Email has been send";
                    opt1 = true;
                }
                
                if (opt == false && opt1 == false)
                {
                    lblError.Text = "Pleaes re-enter your email or user account";
                }
                
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
           
        }
    }
}