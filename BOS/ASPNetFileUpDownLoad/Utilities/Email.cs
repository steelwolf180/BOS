using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Web.Security;
using System.Security.Cryptography;

namespace ASPNetFileUpDownLoad.Utilities
{
    public class Email
    {
        public static string SendOpportunity(string To)
        {
            string Excep = ""; 
            
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add(To);
                mailMessage.From = new MailAddress("maxong@btw.com.sg");
                mailMessage.Subject = "Business Opportunity Founded";
                mailMessage.Body = "Hi there!,\n\nWe had found afew new business opportunity that you may be interested for your company."
                + "Please click the link below to login for more information\nhttp://localhost:24912/ASPNetFileUpDownLoad/Login.aspx";
                SmtpClient smtpClient = new SmtpClient("mail.singnet.com.sg");
                smtpClient.Send(mailMessage);
                Excep = "Email has been sent!";
            }
            catch (Exception ex)
            {
                Excep = "Error: " + ex.Message;
            }

            return Excep;
        }

        public static void SendPassword(string To)
        {
            string password = Membership.GeneratePassword(8, 2);

            try
            {
                Utilities.FileUtilities.PasswordReset(To, password);
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add(To);
                mailMessage.From = new MailAddress("maxong@btw.com.sg");
                mailMessage.Subject = "BOS Account Password Reset";
                mailMessage.Body = "Hi there!,\n\n Here is your new password:" + password.ToString() + "\n\n Please click on the following link to login to BOS with your new password\n\n localhost:24912/ASPNetFileUpDownLoad/Login.aspx";
                SmtpClient smtpClient = new SmtpClient("mail.singnet.com.sg");
                smtpClient.Send(mailMessage);             
            }
            catch (Exception)
            {
            }
           
        }

    }
}