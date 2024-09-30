using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace mvcvalid
{
    public class DateCheck:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                DateTime date = Convert.ToDateTime(value);
                var year = date .Year;
                if (year < 2024)
                {
                    return ValidationResult.Success;
                }
            }
            ErrorMessage = ErrorMessage == null ? "Please check Date" : ErrorMessage;
            return new ValidationResult(ErrorMessage);

        }
    }
}