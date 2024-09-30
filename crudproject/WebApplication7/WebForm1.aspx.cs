using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=ram;Integrated Security=True;Encrypt=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ram WHERE name = @name AND address = @ad AND city = @ct", cn);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@ad", TextBox2.Text);
            cmd.Parameters.AddWithValue("@ct", TextBox3.Text);
            cmd.CommandType = CommandType.Text;

           
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    
                    Response.Write("Data: " + reader["ColumnName"].ToString());
                   
                }
            }
            else
            {
                Response.Write("No rows found.");
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=ram;Integrated Security=True;Encrypt=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("adddata", cn);
            cmd.parameters.AddWithValue("@name", TextBox1.Text);
            cmd.parameters.AddWithValue("@ad", TextBox2.Text);
            cmd.parameters.AddWithValue("@ct", TextBox3.Text);

            cmd.CommandType = CommandType.StoredProcdure;
            int i=cmd.ExecuteNonQuery();

            if (i > 0)
                Response.Write("insertedddd....");
            else
                Response.Write("not insertedddd....");


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=ram;Integrated Security=True");
            cn.Open();
            

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=ram;Integrated Security=True;Encrypt=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("adddata", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", TextBox5.Text);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@ad", TextBox2.Text);
            cmd.Parameters.AddWithValue("@ct", TextBox3.Text);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Response.Write("Updated...");
            else
                Response.Write("Not updated...");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=ram;Integrated Security=True;Encrypt=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("adddata", cn);
            cmd.parameters.AddWithValue("@id", TextBox5.Text);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Response.Write("Deleted...");
            else
                Response.Write("Not deleted...");

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
