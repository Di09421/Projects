using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace securitydemo
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s="select*from form where username='"+TextBox1.Text+"' and password='"+TextBox2.Text+"'";
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=form;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(s, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                if(TextBox1.Text=="admin" && TextBox2.Text=="123")
                {
                    FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, CheckBox1.Checked);
                    Response.Redirect("~/admin/admin_abt.aspx");
                }
                else
                {
                    Response.Write("not successfully");
                }

                }
            else
            {
                Response.Write("invalid");
            }
            }
        }
    }
