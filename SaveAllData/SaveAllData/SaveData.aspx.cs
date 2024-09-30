using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaveAllData
{
    public partial class SaveData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (ViewState["data"] == null)
            {
                dt = new DataTable();
                dt.Columns.Add("name");
                dt.Columns.Add("address");
                dt.Columns.Add("email");
                dt.Columns.Add("mobileno");
            }
            else
                dt = (DataTable)ViewState["data"];
            DataRow dr = dt.NewRow();
            dr["name"] = TextBox1.Text;
            dr["address"] = TextBox2.Text;
            dr["email"] = TextBox3.Text;
            dr["mobileno"] = TextBox4.Text;

            dt.Rows.Add(dr);

            ViewState["data"] = dt;

            GridView1.DataSource = ViewState["data"];
            GridView1.DataBind();

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<GridView1.Rows.Count;i++)
            {
                string nm = GridView1.Rows[i].Cells[0].Text;
                string add = GridView1.Rows[i].Cells[1].Text;
                string em = GridView1.Rows[i].Cells[2].Text;
                string mob = GridView1.Rows[i].Cells[3].Text;

                string q = "insert into data values('" + nm + "','" + add + "','" + em + "','" + mob + "')";
                SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=savedata;Integrated Security=True");
                cn.Open();
                SqlCommand cmd = new SqlCommand(q, cn);
                cmd.ExecuteNonQuery();
            }
            Response.Write("successfully saved data....");
            GridView1.Visible = false;

        }
    }
}