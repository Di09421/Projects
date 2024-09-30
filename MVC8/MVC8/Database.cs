using MVC8.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MVC8
{
    public class Database
    {
        public int RegisterUser(User data)
        {
            using (var DbContext = new MVCEntities2())
            {
                var register = new Login()
                {
                    Name = data.Name,
                    Email = data.Email,
                    Phone = data.Phone,
                    Address=data.Address,
                    City=data.City,
                    State=data.State,
                    Country =data.Country,
                    Password = data.Password,
                };
                DbContext.Logins.Add(register);
                return DbContext.SaveChanges();
            }
        }
        public Login LoginUser(string name, string password)
        {
            using (var DbContext = new MVCEntities2())
            {
                return DbContext.Logins.FirstOrDefault(u => u.Name == name && u.Password == password);
            }
        }
    }
}