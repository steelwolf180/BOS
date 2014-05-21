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
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add("steelwolf180@gmail.com");
                mailMessage.From = new MailAddress("maxong@btw.com.sg");
                mailMessage.Subject = "Business Opportunity Founded";
                mailMessage.Body = "Hi there!,\n\nWe had found afew new business opportunity that you may be interested for your company."
                +"Please click the link below to login for more information\nhttp://localhost:24912/ASPNetFileUpDownLoad/Login.aspx";
                SmtpClient smtpClient = new SmtpClient("mail.singnet.com.sg");
                smtpClient.Send(mailMessage);
                Response.Write("E-mail sent!");
            }
            catch (Exception ex)
            {
                Response.Write("Could not send the e-mail - error: " + ex.Message);
            }
        }
    }
}