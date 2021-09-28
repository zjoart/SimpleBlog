using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleBlog.Models;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Controllers
{
    public class CustomerController : Controller
    {

        public IActionResult Index()
        {
            var customer = new List<Customer>
            {
                new Customer{Name = "Ayomide" },
                new Customer{Name = "Ola" },
                new Customer{Name = "Benji" },
                new Customer{Name = "Alake" }
            };

            var customers = new CustomerViewModel()
            {
                Customers = customer
            };
            return View(customers);
        }
    }
}
