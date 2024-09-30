using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DetailData
{
    public partial class ShowData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string q = "insert into Users (Name,Email,City,Mobile,Address)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";


            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=UserDetails;Integrated Security=True");

            cn.Open();
            SqlCommand cmd = new SqlCommand(q, cn);
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                Response.Write("Successfully inserted...");
            }
            else
            {
                Response.Write("Not inserted...");
            }

            string a = "SELECT Id, Name, Email FROM Users";
            SqlDataAdapter da = new SqlDataAdapter(a, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "SelectRow")
            {
                
                string id = e.CommandArgument.ToString();

                
                Response.Redirect($"Detail.aspx?id={id}");
            }
        }


    }
}


    

