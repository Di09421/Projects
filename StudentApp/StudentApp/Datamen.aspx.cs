using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace StudentApp
{
    public partial class Datamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string q = "insert into Student(name, dob, doj, mobile, address, city, state, country, class, college, obt1, obt2) values (@name, @dob, @doj, @mobile, @address, @city, @state, @country, @class, @college, @obt1, @obt2)";
            using (SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(q, cn))
                {
                    cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@dob", DateTime.Parse(TextBox2.Text));
                    cmd.Parameters.AddWithValue("@doj", DateTime.Parse(TextBox4.Text));
                    cmd.Parameters.AddWithValue("@mobile", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@address", TextBox6.Text);
                    cmd.Parameters.AddWithValue("@city", TextBox7.Text);
                    cmd.Parameters.AddWithValue("@state", TextBox8.Text);
                    cmd.Parameters.AddWithValue("@country", TextBox9.Text);
                    cmd.Parameters.AddWithValue("@class", TextBox10.Text);
                    cmd.Parameters.AddWithValue("@college", TextBox11.Text);
                    cmd.Parameters.AddWithValue("@obt1", TextBox12.Text);
                    cmd.Parameters.AddWithValue("@obt2", TextBox13.Text);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        Response.Write("Successfully inserted.");
                    }
                    else
                    {
                        Response.Write("Insert failed.");
                    }
                }
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Student SET name = @name, dob = @dob, doj = @doj, mobile = @mobile, address = @address, city = @city, state = @state, country = @country, class = @class, college = @college, obt1 = @obt1, obt2 = @obt2 WHERE Id = @Id";
            using (SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@dob", DateTime.Parse(TextBox2.Text));
                    cmd.Parameters.AddWithValue("@doj", DateTime.Parse(TextBox4.Text));
                    cmd.Parameters.AddWithValue("@mobile", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@address", TextBox6.Text);
                    cmd.Parameters.AddWithValue("@city", TextBox7.Text);
                    cmd.Parameters.AddWithValue("@state", TextBox8.Text);
                    cmd.Parameters.AddWithValue("@country", TextBox9.Text);
                    cmd.Parameters.AddWithValue("@class", TextBox10.Text);
                    cmd.Parameters.AddWithValue("@college", TextBox11.Text);
                    cmd.Parameters.AddWithValue("@obt1", TextBox12.Text);
                    cmd.Parameters.AddWithValue("@obt2", TextBox13.Text);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        Response.Write("Update successful.");
                    }
                    else
                    {
                        Response.Write("Update failed.");
                    }
                }
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            string a = "DELETE FROM Student WHERE Id = @Id";
            using (SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(a, cn))
                {
                
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        Response.Write("Student deleted successfully.");
                    }
                    else
                    {
                        Response.Write("Failed to delete student.");
                    }
                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT name, dob, doj, mobile, address, city, state, country, class, college, obt1, obt2 FROM Student WHERE Id = @Id";
            using (SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                 
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        TextBox1.Text = reader["name"].ToString();
                        TextBox2.Text = Convert.ToDateTime(reader["dob"]).ToString("yyyy-MM-dd");
                        TextBox4.Text = Convert.ToDateTime(reader["doj"]).ToString("yyyy-MM-dd");
                        TextBox5.Text = reader["mobile"].ToString();
                        TextBox6.Text = reader["address"].ToString();
                        TextBox7.Text = reader["city"].ToString();
                        TextBox8.Text = reader["state"].ToString();
                        TextBox9.Text = reader["country"].ToString();
                        TextBox10.Text = reader["class"].ToString();
                        TextBox11.Text = reader["college"].ToString();
                        TextBox12.Text = reader["obt1"].ToString();
                        TextBox13.Text = reader["obt2"].ToString();

                        Response.Write("Student details retrieved successfully.");
                    }
                    else
                    {
                        Response.Write("No student found with the provided ID.");
                    }
                }
            }
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Student SET name = @name, dob = @dob, doj = @doj, mobile = @mobile, address = @address, city = @city, state = @state, country = @country, class = @class, college = @college, obt1 = @obt1, obt2 = @obt2 WHERE Id = @Id";
            using (SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@dob", DateTime.Parse(TextBox2.Text));
                    cmd.Parameters.AddWithValue("@doj", DateTime.Parse(TextBox4.Text));
                    cmd.Parameters.AddWithValue("@mobile", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@address", TextBox6.Text);
                    cmd.Parameters.AddWithValue("@city", TextBox7.Text);
                    cmd.Parameters.AddWithValue("@state", TextBox8.Text);
                    cmd.Parameters.AddWithValue("@country", TextBox9.Text);
                    cmd.Parameters.AddWithValue("@class", TextBox10.Text);
                    cmd.Parameters.AddWithValue("@college", TextBox11.Text);
                    cmd.Parameters.AddWithValue("@obt1", TextBox12.Text);
                    cmd.Parameters.AddWithValue("@obt2", TextBox13.Text);
                  
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        Response.Write("Update successful.");
                    }
                    else
                    {
                        Response.Write("Update failed.");
                    }
                }
            }
        }
    }
}
