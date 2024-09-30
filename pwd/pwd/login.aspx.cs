using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pwd
{
    public partial class login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = TextBox1.Text;
            string password = TextBox2.Text;

            string s = "SELECT email, password, status FROM simba WHERE email = @Email AND password = @Password";
            using (SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=simba;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(s, cn))
                {

                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {

                        string status = dr["status"].ToString();
                        if (status == "0")
                        {

                            Response.Redirect("changepwd.aspx?em=" + email + "&pass=" + password);
                        }
                        else if (status == "1")
                        {

                           
                            Response.Redirect("user.aspx");
                        }
                        else
                        {

                            Response.Write("Not a user");
                        }
                    }
                    else
                    {

                        Response.Write("Invalid user");
                    }
                }
            }
        }

    }
}
   
   