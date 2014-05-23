using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetFileUpDownLoad
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Declaration
            string username = "", password = "", email = "", company = "" , hp = "";

            try
            {
                if (txtUsername.Text.Length < 0 | txtUsername.Text == ""| txtUsername.Text == " "| txtUsername.Text == null)
                {
                    lblError.Text = "Error: Please enter username";
                    txtUsername.Focus();
                }
                else
                {
                    if (txtPassword.Text.Length < 0| txtPassword.Text == ""| txtPassword.Text == " "| txtPassword.Text == null)
                    {
                        lblError.Text = "Error: Please enter password";
                        txtPassword.Focus();
                    }
                    else
                    {
                        if (txtEmail.Text.Length < 0 | txtEmail.Text == "" | txtEmail.Text == " " | txtEmail.Text == null)
                        {
                            lblError.Text = "Error: Please enter email";
                            txtEmail.Focus();
                        }
                        else
                        {
                            if (txtCompany.Text.Length < 0 | txtCompany.Text == "" | txtCompany.Text == " " | txtCompany.Text == null)
                            {
                                lblError.Text = "Error: Please enter company";
                                txtCompany.Focus();
                            }
                            else
                            {
                                if (txtHP.Text.Length < 0 | txtHP.Text == "" | txtHP.Text == " " | txtHP.Text == null)
                                {
                                    lblError.Text = "Error: Please enter hp";
                                    txtHP.Focus();
                                }
                                else
                                {
                                    username = txtUsername.Text;
                                    password = txtPassword.Text;
                                    email = txtEmail.Text;
                                    company = txtCompany.Text;
                                    hp = txtHP.Text ;

                                    Session["User"] = username;
                                    // call database to insert into database
                                    Utilities.FileUtilities.AccountCreation(username, password, email, company, hp);
                                    Response.Redirect("Subscription.aspx");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}