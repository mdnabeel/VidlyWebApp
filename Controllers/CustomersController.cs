using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyWebApp.Models;

namespace VidlyWebApp.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.ID == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customers> GetCustomers()
        {
            return new List<Customers>
            {
                new Customers { ID = 1, CustomerName = "John Smith" },
                new Customers { ID = 2, CustomerName = "Mary Williams" },
                new Customers { ID = 3, CustomerName = "Alvaro Morte" },
                new Customers { ID = 4, CustomerName = "Alba Flores" },
                new Customers { ID = 5, CustomerName = "Raquel Murillo" },
                new Customers { ID = 6, CustomerName = "Monica Gaztambide" },
                new Customers { ID = 7, CustomerName = "Arturo Roman" },
            };
        }
    }
}