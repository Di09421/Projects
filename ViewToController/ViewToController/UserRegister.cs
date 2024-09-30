using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ViewToController.Models;

namespace ViewToController
{
    public class UserRegister
    {
        // Insert User Data
        public int RegisterDtlsInsert(string Name, string Email, string Phone, string Address, string City, string State, string Country, string ZipCode, string Password, string ConfirmPassword)
        {
            string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=CrudMvc;Integrated Security=True";
            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                sc.Open();
                string qry = $"Insert into UserRegister values('{Name}','{Email}','{Phone}','{Address}','{City}','{State}','{Country}','{ZipCode}','{Password}','{ConfirmPassword}')";
                SqlCommand scm = new SqlCommand(qry, sc);
                return scm.ExecuteNonQuery() > 0 ? 1 : 0;
            }
        }

        // Update User Data
        public int UpdateProfile(int id, string Name, string Email, string Phone, string Address, string City, string State, string Country, string ZipCode, string Password, string ConfirmPassword)
        {
            string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=CrudMvc;Integrated Security=True";
            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                sc.Open();
                string qry = "UPDATE UserRegister SET Name = @Name, Email=@Email, Phone=@Phone, Address=@Address, City=@City, State=@State, Country=@Country, ZipCode=@ZipCode, Password=@Password, ConfirmPassword=@ConfirmPassword WHERE id=@id";
                SqlCommand scm = new SqlCommand(qry, sc);
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
                scm.Parameters.AddWithValue("@id", id);

                return scm.ExecuteNonQuery() > 0 ? 1 : 0;
            }
        }

        // Get User by Id
        public Register GetUserById(int id)
        {
            string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=CrudMvc;Integrated Security=True";
            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                sc.Open();
                string qry = "SELECT * FROM UserRegister WHERE id=@id";
                SqlCommand scm = new SqlCommand(qry, sc);
                scm.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = scm.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Register
                        {
                            id = Convert.ToInt32(reader["id"]),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Address = reader["Address"].ToString(),
                            City = reader["City"].ToString(),
                            State = reader["State"].ToString(),
                            Country = reader["Country"].ToString(),
                            ZipCode = reader["ZipCode"].ToString(),
                            Password = reader["Password"].ToString(),
                            ConfirmPassword = reader["ConfirmPassword"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        // Delete User
        public int DeleteProfile(int id)
        {
            string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=CrudMvc;Integrated Security=True";
            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                sc.Open();
                string qry = "DELETE FROM UserRegister WHERE id=@id";
                SqlCommand scm = new SqlCommand(qry, sc);
                scm.Parameters.AddWithValue("@id", id);

                return scm.ExecuteNonQuery() > 0 ? 1 : 0;
            }
        }

        // Get All Users
        public List<Register> GetAllUsers()
        {
            List<Register> users = new List<Register>();
            string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=CrudMvc;Integrated Security=True";
            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                sc.Open();
                string qry = "SELECT * FROM UserRegister";
                SqlCommand scm = new SqlCommand(qry, sc);

                using (SqlDataReader reader = scm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new Register
                        {
                            id = Convert.ToInt32(reader["id"]),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Address = reader["Address"].ToString(),
                            City = reader["City"].ToString(),
                            State = reader["State"].ToString(),
                            Country = reader["Country"].ToString(),
                            ZipCode = reader["ZipCode"].ToString(),
                            Password = reader["Password"].ToString(),
                            ConfirmPassword = reader["ConfirmPassword"].ToString()
                        });
                    }
                }
            }
            return users;
        }
    }
}
