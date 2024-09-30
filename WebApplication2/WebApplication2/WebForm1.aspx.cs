using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string s = "select*from data";
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=show;Integrated Security=True");
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Button1_Click(sender, e);

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
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
            string q = "update data set name='" + nm.Text + "',address='" + ad.Text + "',city='" + ct.Text + "' where id = " + id;
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=show;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(q, cn);
            cmd.ExecuteNonQuery();

            GridView1.EditIndex = -1;
            Button1_Click(sender, e);


        }
    }
}