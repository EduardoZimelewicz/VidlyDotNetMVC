using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        [Route("Movies")]
        public IActionResult Movies()
        {
            var movies = new List<Movie> 
            { 
                new Movie { Name = "Shrek" },
                new Movie { Name = "Wall-e" }
            };

            var viewModel = new MoviesViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }
    }
}