using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Signup
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Today;
                DropDownList1.Items.Add(new ListItem("Select Gender", ""));
                DropDownList1.Items.Add(new ListItem("Male", "Male"));
                DropDownList1.Items.Add(new ListItem("Female", "Female"));
                DropDownList1.Items.Add(new ListItem("Other", "Other"));
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime dob = Calendar1.SelectedDate;
            Response.Write("Selected Date: " + dob.ToShortDateString());
            Response.Write("<br/>Calculated Age: " + AgeCalc);
            TextBox2.Text = AgeCalc.ToString();
        }

        
        public int AgeCalc
        {
            get
            {
                DateTime dob = Calendar1.SelectedDate; 
                DateTime now = DateTime.Today;
                int age = now.Year - dob.Year;

                
                if (dob > now.AddYears(-age))
                    age--;

                return age;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if (Calendar1.SelectedDate == DateTime.MinValue)
            {
                Response.Write("Please select a date.");
                return;
            }
            if (string.IsNullOrEmpty(DropDownList1.SelectedValue))
            {
                Response.Write("Please select a gender.");
                return;
            }


            string name = TextBox1.Text; 
            DateTime dob = Calendar1.SelectedDate; 
            int age = AgeCalc; 
            string gender = DropDownList1.SelectedValue; 
            string email = TextBox3.Text; 
            string mobile = TextBox4.Text; 

           
            string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=reg;Integrated Security=True";

            
            string query = "INSERT INTO reg (Name, DOB, Age, Gender, Email, Mobile) VALUES (@Name, @DOB, @Age, @Gender, @Email, @Mobile)";

            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Mobile", mobile);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        Response.Write("Registration successful!<script>alert('thanku for registration')</script>");
                    }
                    catch (Exception ex)
                    {
                        
                        Response.Write("An error occurred: " + ex.Message);
                    }
                }
            }
        }
    }
}
