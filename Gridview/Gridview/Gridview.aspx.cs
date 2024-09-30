using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gridview
{
    public partial class GridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select*from tbl";
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=ass3;Integrated Security=True");
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Button1_Click(sender, e);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();

            string query = "DELETE FROM tbl WHERE Id = @Id";
            using (SqlConnection con = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=ass3;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    GridView1.EditIndex = -1;
                    Button1_Click(sender, e);
                }
            }
        }

        protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Button1_Click(sender, e);
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            string id = GridView1.Rows[e.RowIndex].Cells[0].Text;
            TextBox nm = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox ad = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox ct = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];

            // Correctly use the Text property of the TextBox controls
            string query = "UPDATE tbl SET Name = @Name, Address = @Address, City = @City WHERE Id = @Id";
            SqlConnection con = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=ass3;Integrated Security=True");
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Name", nm.Text);  // Use nm.Text to get the input value
                cmd.Parameters.AddWithValue("@Address", ad.Text);
                cmd.Parameters.AddWithValue("@City", ct.Text);
                cmd.Parameters.AddWithValue("@Id", id);
                
                con.Open();
                cmd.ExecuteNonQuery();
            }

            GridView1.EditIndex = -1;
            Button1_Click(sender, e);
        }

    }
    }





