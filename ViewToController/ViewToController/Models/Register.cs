using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewToController.Models
{
    public class Register
    {

        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}