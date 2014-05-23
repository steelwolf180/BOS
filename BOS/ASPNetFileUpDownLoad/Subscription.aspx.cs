using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetFileUpDownLoad
{
    public partial class Subscription : System.Web.UI.Page
    {
        int option;

        protected void Page_Load(object sender, EventArgs e)
        {
            option = 0;
        }

        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            try
            {
                option = int.Parse(RBLPlans.SelectedValue);
                
                switch (option)
                {
                    case 1:
                        Session.Add("ContractTypeID", option);
                        Session.Add("Period", 6);
                        Session.Add("StartDate", DateTime.Today.ToShortDateString());
                        Session.Add("EndDate", DateTime.Today.AddMonths(6).ToShortDateString());
                        Response.Redirect("SubscriptionDetails.aspx");
                        break;
                    case 2:
                        Session.Add("ContractTypeID", option);
                        Session.Add("Period", 12);
                        Session.Add("StartDate", DateTime.Today.ToShortDateString());
                        Session.Add("EndDate", DateTime.Today.AddMonths(12).ToShortDateString());
                        Response.Redirect("SubscriptionDetails.aspx");
                        break;
                    case 3:
                        Session.Add("ContractTypeID", option);
                        Session.Add("Period", 6);
                        Session.Add("StartDate", DateTime.Today.ToShortDateString());
                        Session.Add("EndDate", DateTime.Today.AddMonths(6).ToShortDateString());
                        Response.Redirect("SubscriptionDetails2.aspx");
                        break;
                    case 4:
                        Session.Add("ContractTypeID", option);
                        Session.Add("Period", 12);
                        Session.Add("StartDate", DateTime.Today.ToShortDateString());
                        Session.Add("EndDate", DateTime.Today.AddMonths(12).ToShortDateString());
                        Response.Redirect("SubscriptionDetails2.aspx");
                        break;                
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }            
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}