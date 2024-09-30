using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace WebApplication11
{
    public partial class regiestration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pwd=RandomString(8, true);
            SmtpClient obj = new SmtpClient();
            obj.Credentials = new NetworkCredential("cs.dikshadwivedi@gmail.com","diksha@178");
            obj.Port = 587;
            obj.Host = "smtp.gmail.com";
            obj.EnableSsl = true;


            MailMessage msg = new MailMessage("cs.dikshadwivedi@gmail.com", TextBox2.Text);
            msg.Subject = "thank you for registration....";
            string m = "your credentials are as follow \n your user name is "+TextBox2.Text+"\n your password is :"+pwd;
            msg.Body = "m";

            obj.Send(msg);
            Response.Write("successfully registered and check your email.......");
        }
    }
}