using System;
using System.ComponentModel.DataAnnotations;

namespace mvcvalid.Models
{
    public class student
    {
        [Required(ErrorMessage = "Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Your Age")]
        [Range(18, 22, ErrorMessage = "Enter a valid age between 18 and 22")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter your Address")]
        [StringLength(20, ErrorMessage = "Address can be up to 20 characters long.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter Your Email")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Your Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Enter Your Phone")]
        [Phone(ErrorMessage = "Enter a valid phone number")]
        public string Phone { get; set; }
    }
}
