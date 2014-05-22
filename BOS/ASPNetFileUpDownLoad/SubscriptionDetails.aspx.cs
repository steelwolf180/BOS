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
        string keyword1, keyword2, keyword3;
        protected void Page_Load(object sender, EventArgs e)
        {
            keyword1 = "";
            keyword2 = "";
            keyword3 = "";
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Subscription.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string Username = (string)(Session["User"]);
            string UserID = ;
            string ContracttypeID = (string)(Session["ContractTypeID"]);
            string Period = (string)(Session["Period"]);
            string sDate = (string)(Session["StartDate"]);
            string eDate = (string)(Session["EndDate"]);


            keyword1 = tbKW1.Text;
            keyword2 = tbKW2.Text;
            keyword3 = tbKW3.Text;


            if (Period == "6")
	        {
                
                Utilities.Subscription.Subscript3KW6M(Username,keyword1,keyword2,keyword3,ContracttypeID,Period,sDate,eDate);    
	        }
            else
            {
                Utilities.Subscription.
            }
            
          
            Response.Redirect("Login.aspx");
        }
    }
}