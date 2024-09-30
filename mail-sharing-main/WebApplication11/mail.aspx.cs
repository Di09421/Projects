using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace WebApplication11
{
    public partial class mail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_email_Click(object sender, EventArgs e)
        {
            SmtpClient obj = new SmtpClient();
            obj.Credentials = new NetworkCredential(txt_from.Text,txt_pwd.Text);
            obj.Port = 587;
            obj.Host = "smtp.gmail.com";
            obj.EnableSsl= true;

            MailMessage msg = new MailMessage(txt_from.Text, txt_to.Text, txt_subject.Text, txt_body.Text);
            obj.Send(msg);

            Response.Write("sending....");

        }
    }
}