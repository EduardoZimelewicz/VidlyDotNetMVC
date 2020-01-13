using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        [Route("Customers")]
        public IActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 0, Name = "John Smith" },
                new Customer { Id = 1, Name = "Mary Williams" }
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("Customers/Details/{id}")]
        public IActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 0, Name = "John Smith" },
                new Customer { Id = 1, Name = "Mary Williams" }
            };

            return View(customers.ElementAt(id));
        }
    }
}