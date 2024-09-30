using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Genratepassword
{
    public partial class Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private string GenerateRandomPassword()
        {
            
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            char[] chars = new char[8];
            Random rand = new Random();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = allowedChars[rand.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }
    
    protected void Button1_Click(object sender, EventArgs e)
        {
            string Password = GenerateRandomPassword();
            string s = "insert into DETAIL (NAME, EMAIL, MOBILE, PASSWORD) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + Password + "')";
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=password;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(s, cn);
            int i = cmd.ExecuteNonQuery();
            if(i>0)
            {
                Response.Write("successfully register");
                Response.Redirect("Submit.aspx?nm="+TextBox1.Text+"&em="+TextBox2.Text+"&pass="+Password);

            }
            else
            {
                Response.Write("not successfully inserttteddd");
            }

        }
    }
}