using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (ViewState["data"]==null)
            {
                dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("Address");
                dt.Columns.Add("City");
            }
            else
                dt=(DataTable)ViewState["data"];

            DataRow dr = dt.NewRow();
            dr["Name"] = TextBox1.Text;
            dr["Address"] = TextBox2.Text;
            dr["City"] = TextBox3.Text;

            dt.Rows.Add(dr);
            ViewState["data"] = dt;

            GridView1.DataSource = ViewState["data"];
            GridView1.DataBind();


            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<GridView1.Rows.Count;i++)
            {
                string nm = GridView1.Rows[i].Cells[0].Text;
                string ad = GridView1.Rows[i].Cells[1].Text;
                string ct = GridView1.Rows[i].Cells[2].Text;

                string q = "insert into data values('" + nm + "','" + ad + "','" + ct + "')";
                SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=show;Integrated Security=True");
                cn.Open();
                SqlCommand cmd = new SqlCommand(q, cn);
                cmd.ExecuteNonQuery();
            }

            Response.Write("successfully saved....");
            GridView1.Visible = false;
        }
    }
}