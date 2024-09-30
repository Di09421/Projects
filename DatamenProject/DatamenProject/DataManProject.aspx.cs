using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace DatamenProject
{
    public partial class DataManProject : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e) // Add
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Student(Name, Age, DateOfBirth, DateOfJoining, Address, Mobile, City, State, Country, Class, College, Obtaining, Obtained, Percentage, Overall) VALUES (@Name, @Age, @DateOfBirth, @DateOfJoining, @Address, @Mobile, @City, @State, @Country, @Class, @College, @Obtaining, @Obtained, @Percentage, @Overall)", conn);
                cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(TextBox6.Text));
                cmd.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(TextBox2.Text));
                cmd.Parameters.AddWithValue("@DateOfJoining", Convert.ToDateTime(TextBox3.Text));
                cmd.Parameters.AddWithValue("@Address", TextBox4.Text);
                cmd.Parameters.AddWithValue("@Mobile", TextBox7.Text);
                cmd.Parameters.AddWithValue("@City", DropDownList1.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@State", TextBox5.Text);
                cmd.Parameters.AddWithValue("@Country", TextBox8.Text);
                cmd.Parameters.AddWithValue("@Class", TextBox9.Text);
                cmd.Parameters.AddWithValue("@College", TextBox10.Text);
                cmd.Parameters.AddWithValue("@Obtaining", Convert.ToSingle(TextBox11.Text));
                cmd.Parameters.AddWithValue("@Obtained", Convert.ToSingle(TextBox12.Text));
                cmd.Parameters.AddWithValue("@Percentage", Convert.ToSingle(TextBox13.Text));
                cmd.Parameters.AddWithValue("@Overall", Convert.ToSingle(TextBox24.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                LoadData(); // Refresh GridView
            }
        }

        protected void Button2_Click(object sender, EventArgs e) // Edit
        {
            // Assume the first cell of the selected row contains the ID of the record
            if (GridView1.SelectedRow != null)
            {
                int id = Convert.ToInt32(GridView1.SelectedRow.Cells[0].Text);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Student SET Name=@Name, Age=@Age, DateOfBirth=@DateOfBirth, DateOfJoining=@DateOfJoining, Address=@Address, Mobile=@Mobile, City=@City, State=@State, Country=@Country, Class=@Class, College=@College, Obtaining=@Obtaining, Obtained=@Obtained, Percentage=@Percentage, Overall=@Overall WHERE ID=@ID", conn);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(TextBox6.Text));
                    cmd.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(TextBox2.Text));
                    cmd.Parameters.AddWithValue("@DateOfJoining", Convert.ToDateTime(TextBox3.Text));
                    cmd.Parameters.AddWithValue("@Address", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Mobile", TextBox7.Text);
                    cmd.Parameters.AddWithValue("@City", DropDownList1.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@State", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@Country", TextBox8.Text);
                    cmd.Parameters.AddWithValue("@Class", TextBox9.Text);
                    cmd.Parameters.AddWithValue("@College", TextBox10.Text);
                    cmd.Parameters.AddWithValue("@Obtaining", Convert.ToSingle(TextBox11.Text));
                    cmd.Parameters.AddWithValue("@Obtained", Convert.ToSingle(TextBox12.Text));
                    cmd.Parameters.AddWithValue("@Percentage", Convert.ToSingle(TextBox13.Text));
                    cmd.Parameters.AddWithValue("@Overall", Convert.ToSingle(TextBox24.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadData(); // Refresh GridView
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e) // Delete
        {
            if (GridView1.SelectedRow != null)
            {
                int id = Convert.ToInt32(GridView1.SelectedRow.Cells[0].Text);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE ID=@ID", conn);
                    cmd.Parameters.AddWithValue("@ID", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadData(); // Refresh GridView
                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e) // Find
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE Name = @Name", conn);
                cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void Button5_Click(object sender, EventArgs e) // Save
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd;
                if (HiddenFieldMode.Value == "Edit") // Check if we are in edit mode
                {
                    // Assume the first cell of the selected row contains the ID of the record
                    int id = Convert.ToInt32(GridView1.SelectedRow.Cells[0].Text);
                    cmd = new SqlCommand("UPDATE Student SET Name=@Name, Age=@Age, DateOfBirth=@DateOfBirth, DateOfJoining=@DateOfJoining, Address=@Address, Mobile=@Mobile, City=@City, State=@State, Country=@Country, Class=@Class, College=@College, Obtaining=@Obtaining, Obtained=@Obtained, Percentage=@Percentage, Overall=@Overall WHERE ID=@ID", conn);
                    cmd.Parameters.AddWithValue("@ID", id);
                }
                else // Add mode
                {
                    cmd = new SqlCommand("INSERT INTO Student(Name, Age, DateOfBirth, DateOfJoining, Address, Mobile, City, State, Country, Class, College, Obtaining, Obtained, Percentage, Overall) VALUES (@Name, @Age, @DateOfBirth, @DateOfJoining, @Address, @Mobile, @City, @State, @Country, @Class, @College, @Obtaining, @Obtained, @Percentage, @Overall)", conn);
                }

                // Add common parameters
                cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(TextBox6.Text));
                cmd.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(TextBox2.Text));
                cmd.Parameters.AddWithValue("@DateOfJoining", Convert.ToDateTime(TextBox3.Text));
                cmd.Parameters.AddWithValue("@Address", TextBox4.Text);
                cmd.Parameters.AddWithValue("@Mobile", TextBox7.Text);
                cmd.Parameters.AddWithValue("@City", DropDownList1.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@State", TextBox5.Text);
                cmd.Parameters.AddWithValue("@Country", TextBox8.Text);
                cmd.Parameters.AddWithValue("@Class", TextBox9.Text);
                cmd.Parameters.AddWithValue("@College", TextBox10.Text);
                cmd.Parameters.AddWithValue("@Obtaining", Convert.ToSingle(TextBox11.Text));
                cmd.Parameters.AddWithValue("@Obtained", Convert.ToSingle(TextBox12.Text));
                cmd.Parameters.AddWithValue("@Percentage", Convert.ToSingle(TextBox13.Text));
                cmd.Parameters.AddWithValue("@Overall", Convert.ToSingle(TextBox24.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                LoadData(); // Refresh GridView
            }

            // Reset the hidden field and the input fields after saving
            HiddenFieldMode.Value = "Add"; // Reset to Add mode
            ClearInputFields(); // Create a method to clear input fields
        }

        private void ClearInputFields()
        {
            TextBox1.Text = "";
            TextBox6.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox7.Text = "";
            TextBox5.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox24.Text = "";
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            TextBox1.Text = row.Cells[1].Text; // Adjust index based on your columns
            TextBox6.Text = row.Cells[2].Text;
            // Populate other TextBoxes similarly

            HiddenFieldMode.Value = "Edit"; // Set the mode to Edit
        }

    }
}

