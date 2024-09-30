using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

namespace pwd
{
    public partial class submit : System.Web.UI.Page
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

            using (SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=simba;Integrated Security=True"))
            {
                string s = "INSERT INTO simba (name, address, email, mobile, status, password) VALUES (@Name, @Address, @Email, @Mobile, @Status, @Password)";
                using (SqlCommand cmd = new SqlCommand(s, cn))
                {
                    cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Address", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Email", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@Mobile", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Status", 0);
                    cmd.Parameters.AddWithValue("@Password", Password);

                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        Response.Write("successfully inserted");
                        Response.Redirect("submit.aspx?em=" + TextBox3.Text + "&pass=" + Password);
                    }
                    else
                    {
                        Response.Write("not successfully inserted");
                    }
                }
            }
        }
    }
}