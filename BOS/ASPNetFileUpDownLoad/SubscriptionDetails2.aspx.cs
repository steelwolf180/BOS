using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetFileUpDownLoad
{
    public partial class SubscriptionDetails2 : System.Web.UI.Page
    {
        string keyword1, keyword2, keyword3, keyword4, keyword5, keyword6, keyword7, keyword8, keyword9, keyword10;
        bool renewal;

        protected void Page_Load(object sender, EventArgs e)
        {
            keyword1 = "";
            keyword2 = "";
            keyword3 = "";
            keyword4 = "";
            keyword5 = "";
            keyword6 = "";
            keyword7 = "";
            keyword8 = "";
            keyword9 = "";
            keyword10 = "";
            renewal = false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                renewal = (bool)(Session["Renewal"]);
                string Username = (string)(Session["User"]);
                int ContracttypeID = (int)(Session["ContractTypeID"]);
                int Period = (int)(Session["Period"]);
                string sDate = (string)(Session["StartDate"]);
                string eDate = (string)(Session["EndDate"]);
                int UserID = 0, SubID = 0;

                if (tbKW1.Text.Length == 0 || tbKW2.Text.Length == 0 || tbKW3.Text.Length == 0 || tbKW4.Text.Length == 0 || tbKW5.Text.Length == 0 || tbKW6.Text.Length == 0 || tbKW7.Text.Length == 0 || tbKW8.Text.Length == 0 || tbKW9.Text.Length == 0 || tbKW10.Text.Length == 0)
                {
                    lblError.Text = "Please enter all your keywords";
                }
                else
                {
                    keyword1 = tbKW1.Text;
                    keyword2 = tbKW2.Text;
                    keyword3 = tbKW3.Text;
                    keyword4 = tbKW4.Text;
                    keyword5 = tbKW5.Text;
                    keyword6 = tbKW6.Text;
                    keyword7 = tbKW7.Text;
                    keyword8 = tbKW8.Text;
                    keyword9 = tbKW9.Text;
                    keyword10 = tbKW10.Text;

                    UserID = Utilities.Subscription.GetAccountID(Username);
                    SubID = Utilities.Subscription.GetSubscriptionID(UserID);

                    if (renewal == true)
                    {
                        Utilities.Subscription.Renewal10KW(SubID,UserID, keyword1, keyword2, keyword3, keyword4, keyword5, keyword6, keyword7, keyword8, keyword9, keyword10, ContracttypeID, Period, sDate, eDate);
                    }
                    else
                    {
                        Utilities.Subscription.Subscription10KW(UserID, keyword1, keyword2, keyword3, keyword4, keyword5, keyword6, keyword7, keyword8, keyword9, keyword10, ContracttypeID, Period, sDate, eDate);
                    }
                    Response.Redirect("Login.aspx");
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Subscription.aspx");
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}