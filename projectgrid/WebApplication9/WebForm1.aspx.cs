using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            
            SqlConnection con = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=ass3;Integrated Security=True");
            con.Open();
           SqlCommand cmd=new SqlCommand("griddata", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", nm);
            cmd.Parameters.AddWithValue("@address", ad);
            cmd.Parameters.AddWithValue("@city", ct);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
                    
                DataSet ds = new DataSet();
                da.Fill(ds);
               
                GridView1.DataSource = ds;
            GridView1.DataBind();
            TextBox1.Text = "";
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            

        }
    }


}
   
