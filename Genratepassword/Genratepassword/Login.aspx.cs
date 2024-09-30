using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Genratepassword
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select email,password,status,user_type from DETAIL where email='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=password;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(s, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["EMAIL"].ToString() =="admin@gmail.com" && dr["PASSWORD"].ToString() == "admin" && dr["user_type"].ToString() == "admin")
                {
                    Response.Redirect("admin.aspx");
                }
                else if (dr["status"].ToString()=="1")
                {
                    Response.Redirect("user.aspx");
                }
                else
                {
                    Response.Write("you are not approved please try again after some time....");
                }
            }
            else
            {
                Response.Write("invaild user.....");
            }
        }
    }
}
