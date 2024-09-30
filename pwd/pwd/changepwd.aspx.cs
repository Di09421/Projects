using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pwd
{
    public partial class changepwd : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string oldPassword = Request.QueryString["pass"];
            string email = Request.QueryString["em"];

            if (TextBox1.Text == oldPassword)
            {
                if (TextBox2.Text == TextBox3.Text)
                {
                    string newPassword = TextBox2.Text;

                    string c = "UPDATE simba SET password = @NewPassword, status = 1 WHERE email = @Email";
                    using (SqlConnection cnn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=simba;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand(c, cnn))
                        {
                            cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                            cmd.Parameters.AddWithValue("@Email", email);

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                Response.Write("Your Password Changed");
                            }
                            else
                            {
                                Response.Write("Your Password Not Changed");
                            }
                        }
                    }
                }
                else
                {
                    Response.Write("Passwords do not match");
                }
            }
            else
            {
                Response.Write("Old password does not match");
            }
        }
    }

}
   