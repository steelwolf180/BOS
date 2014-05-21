using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace ASPNetFileUpDownLoad
{
    public partial class Send_Mail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Utilities.Email.SendOpportunity("steelwolf180@gmail.com"));
        }
    }
}