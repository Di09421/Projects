using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_operations
{
    public partial class Crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string q= "INSERT INTO student(studentid, name, address, age, contact) VALUES('"+ TextBox1.Text + "', '"  + TextBox2.Text + "', '" + DropDownList1.Text + "', "+ TextBox3.Text + ", '" + TextBox4.Text + "');";
            SqlConnection con = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=crud;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            int i = cmd.ExecuteNonQuery();
            if(i>0)
            {
                Response.Write("<script>alert('Successfully inserted...');</script>");
            }
            else
            {
                Response.Write("<script>alert('Insertion failed...');</script>");
            }
            
        }
    }
}