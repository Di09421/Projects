using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ViewToController
{
    public class DBwork
    {
        public int LoginDtlsInsert(string userName, string password)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=App_Data\\MVCB2.mdf;Integrated Security=True";
            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                sc.Open();
                string qry = $"Insert into LoginDtls values('{userName}','{password}')";

                SqlCommand scm = new SqlCommand(qry, sc);
                int i = scm.ExecuteNonQuery();
                if (i > 0)
                    return 1;
                return 0;
            }
        }

    }
}
