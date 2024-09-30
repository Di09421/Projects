using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Collections;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            string userid = TextBox1.Text;
            string userpassword = TextBox2.Text;
            string usertype = TextBox3.Text;

         
            string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=dd;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Open the connection
                con.Open();

                // Define the command and set its properties
                using (SqlCommand cmd = new SqlCommand("logindatta", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add the parameters
                    cmd.Parameters.Add(new SqlParameter("@userid", userid));
                    cmd.Parameters.Add(new SqlParameter("@userpassword", userpassword));
                    cmd.Parameters.Add(new SqlParameter("@usertype", usertype));


                    // Execute the command
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // If a record is found, redirect to the user page
                            Response.Redirect("user.aspx?&a=" + TextBox1.Text);
                        }
                        else
                        {
                            // Handle invalid login
                            // You could show a message to the user or handle it accordingly
                        }
                    }
                }
            }
        }
    }
}
