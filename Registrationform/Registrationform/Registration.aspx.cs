using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace Registrationform
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string b = "INSERT INTO basic (name, address, email, mobile_no, city, state) " +
                                "VALUES (@Name, @Address, @Email, @MobileNo, @City, @State); " +
                                "SELECT SCOPE_IDENTITY();";

            using (SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True"))
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand(b, cn))
                {
                    
                    cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Address", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Email", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@MobileNo", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@City", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@State", TextBox6.Text);

                    
                    int basicDetailId = Convert.ToInt32(cmd.ExecuteScalar());

                   
                    string l = "INSERT INTO login (basic_id, username, password) " +
                                        "VALUES (@BasicId, @Username, @Password)";

                    using (SqlCommand cmd2 = new SqlCommand(l, cn))
                    {
                      
                        cmd2.Parameters.AddWithValue("@BasicId", basicDetailId);
                        cmd2.Parameters.AddWithValue("@Username", TextBox7.Text);
                        cmd2.Parameters.AddWithValue("@Password", TextBox8.Text);

                        int j = cmd2.ExecuteNonQuery();
                        if (j > 0)
                        {
                            Response.Write("Registration successfully completed");
                        }
                        else
                        {
                            Response.Write("Failed to register login details");
                        }
                    }
                }
            }
        }
    }
}
