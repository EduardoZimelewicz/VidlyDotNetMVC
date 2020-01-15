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
        
        public String Name { get; set; }
        
        public Genre Genre { get; set; }
        
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        
        [Display(Name = "Release date")]
        public String ReleaseDate { get; set; }
        
        public String DateAdded { get; set; }
        
        [Display(Name = "Number in stock")]
        public int NumberInStock { get; set; }
    }
}
