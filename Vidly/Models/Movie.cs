using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        public String Name { get; set; }
        
        
        public Genre Genre { get; set; }
        
        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }
        
        [Required]
        [Display(Name = "Release date")]
        public String ReleaseDate { get; set; }

        public String DateAdded { get; set; }
        
        [Required]
        [NumbersInStockMinAndMax]
        [Display(Name = "Number in stock")]
        public int? NumberInStock { get; set; }
    }
}
