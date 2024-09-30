using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project
{
    public partial class Dataman : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string q = "insert into Student(name,dateofbirth,dateofjoining,address,city,state,age,mobile,country,class,college,obtained1,obtained2)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "')";
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(q, cn);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("successfully...");
            }
            else
            {
                Response.Write("failed");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int StudentId = 1;
            HiddenFieldStudentId.Value = StudentId.ToString();

            string a = "SELECT name, dateofbirth, dateofjoining, address, city, state, age, mobile, country, class, obtained1, obtained2 FROM Student WHERE StudentId = StudentId";

            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(a, cn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TextBox1.Text = reader["name"].ToString();
                TextBox2.Text = reader["dateofbirth"].ToString();
                TextBox3.Text = reader["dateofjoining"].ToString();
                TextBox4.Text = reader["address"].ToString();
                TextBox5.Text = reader["city"].ToString();
                TextBox6.Text = reader["state"].ToString();
                TextBox7.Text = reader["age"].ToString();
                TextBox8.Text = reader["mobile"].ToString();
                TextBox9.Text = reader["country"].ToString();
                TextBox10.Text = reader["class"].ToString();
                TextBox11.Text = reader["obtained1"].ToString();
                TextBox12.Text = reader["obtained2"].ToString();

                Response.Write("successfully...");
            }
            else
            {
                Response.Write("Student not found");
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string a = "DELETE FROM Student WHERE StudentId = StudentId";
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(a, cn);
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                Response.Write("Student deleted successfully...");
            }
            else
            {
                Response.Write("Failed to delete student");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int StudentId = 1;
            HiddenFieldStudentId.Value = StudentId.ToString();

            string a = "SELECT name, dateofbirth, dateofjoining, address, city, state, age, mobile, country, class, obtained1, obtained2 FROM Student WHERE StudentId = StudentId";

            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(a, cn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TextBox1.Text = reader["name"].ToString();
                TextBox2.Text = reader["dateofbirth"].ToString();
                TextBox3.Text = reader["dateofjoining"].ToString();
                TextBox4.Text = reader["address"].ToString();
                TextBox5.Text = reader["city"].ToString();
                TextBox6.Text = reader["state"].ToString();
                TextBox7.Text = reader["age"].ToString();
                TextBox8.Text = reader["mobile"].ToString();
                TextBox9.Text = reader["country"].ToString();
                TextBox10.Text = reader["class"].ToString();
                TextBox11.Text = reader["obtained1"].ToString();
                TextBox12.Text = reader["obtained2"].ToString();

                Response.Write("found....");
            }
            else
            {
                Response.Write("Student not found");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int StudentId = 1;
            HiddenFieldStudentId.Value = StudentId.ToString();

            string a = "UPDATE Student SET name = '"+TextBox1.Text+ "', dateofbirth = '"+TextBox2.Text+ "', dateofjoining = '"+TextBox3.Text+ "', address = '"+TextBox4.Text+ "', city ='"+TextBox5.Text+ "', state = '"+TextBox6.Text+ "', age = '"+TextBox7.Text+ "', mobile = '"+TextBox8.Text+ "', country = '"+TextBox9.Text+ "', class = '"+TextBox10.Text+ "',college='"+TextBox11.Text+"', obtained1 ='"+TextBox12.Text+ "', obtained2 = '"+TextBox13.Text+"' WHERE StudentId = StudentId";
            SqlConnection cn = new SqlConnection("Data Source = HP\\SQLEXPRESS; Initial Catalog = project; Integrated Security = True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(a, cn);
            int i = cmd.ExecuteNonQuery();
            if(i>0)
            {
                Response.Write("Student updated successfully...");
            }
            else
            {
                Response.Write("failed...");
            }

        }
    }
    }
