using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Required]
        [Display(Name = "Release date")]
        public String ReleaseDate { get; set; }

        [Required]
        //[NumbersInStockMinAndMax]
        [Display(Name = "Number in stock")]
        public int? NumberInStock { get; set; }
    }
}
