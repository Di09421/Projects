using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace DetailData
{
    public partial class Show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                string id = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(id))
                {
                    
                    GetData(id);
                }
            }
        }

        private void GetData(string id)
        {
            string query = "SELECT * FROM Users WHERE Id = @Id";
            string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=UserDetails;Integrated Security=True";

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                   
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
        }
    }
}
       

