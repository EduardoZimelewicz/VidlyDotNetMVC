using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class NumbersInStockMinAndMax : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            return (movie.NumberInStock >= 1 && movie.NumberInStock <= 20) ? ValidationResult.Success : 
                new ValidationResult("A film stock must be within 1 and 20 copies");

        }
    }
}
