using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Web;
using System.Web.Helpers;
using System.Xml.Linq;

namespace ViewToController
{
    public class EditProfile
    {
        public int UpdateProfile(int id, string Name, string Email, string Phone, string Address, string City, string State, string Country, string ZipCode, string Password, string ConfirmPassword)
        {
            string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=CrudMvc;Integrated Security=True";

            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                sc.Open();

               
                string qry = $"UPDATE UserRegister SET Name = @Name, Email = @Email, Phone = @Phone, Address = @Address, City = @City, State = @State, Country = @Country, ZipCode = @ZipCode, Password = @Password, ConfirmPassword = @ConfirmPassword WHERE Id = @Id";

                using (SqlCommand scm = new SqlCommand(qry, sc))
                {
                    
                    scm.Parameters.AddWithValue("@Id", id);
                    scm.Parameters.AddWithValue("@Name", Name);
                    scm.Parameters.AddWithValue("@Email", Email);
                    scm.Parameters.AddWithValue("@Phone", Phone);
                    scm.Parameters.AddWithValue("@Address", Address);
                    scm.Parameters.AddWithValue("@City", City);
                    scm.Parameters.AddWithValue("@State", State);
                    scm.Parameters.AddWithValue("@Country", Country);
                    scm.Parameters.AddWithValue("@ZipCode", ZipCode);
                    scm.Parameters.AddWithValue("@Password", Password);
                    scm.Parameters.AddWithValue("@ConfirmPassword", ConfirmPassword);

                    
                    return scm.ExecuteNonQuery();
                }
            }
        }

      

    }
}