using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Genratepassword
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            admin ad = new admin();
            ad.binddata();

            string s = "select name,status from DETAIL where status=0";
               SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=password;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(s, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Response.Write(dr["Name"].ToString() + "<br/>");
            }
        }
        public void binddata() 
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "update DETAIL set status=1 where status=0";
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=password;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(s, cn);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("all data approved");
                string a = "select name,status from DETAIL where status=0";
                SqlConnection con=new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=password;Integrated Security=True");
                con.Open();
                SqlCommand cm = new SqlCommand(a, con);
                SqlDataReader dr = cm.ExecuteReader();
               while(dr.Read()) 
                {
                    Response.Write(dr["Name"].ToString() + "<br/>");
                }
            }
        }
    }
}