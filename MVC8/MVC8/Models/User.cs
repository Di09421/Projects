using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC8.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Password { get; set; }
    }
}