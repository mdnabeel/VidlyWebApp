using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyWebApp.Models;
using VidlyWebApp.ViewModels;
using System.Web.UI.WebControls;

namespace VidlyWebApp.Controllers
{
    [System.Runtime.InteropServices.Guid("D43DB447-6F98-49C7-B1FA-3AAA70FE8427")]
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        public ActionResult New()
        {
            var membershipType = _context.MembershipTypes.ToList();

            var viewmodel = new CustomerFormViewModel
            {
                MembershipTypes = membershipType
        };
            return View("CustomerForm" ,viewmodel);
        }



[HttpPost]
        public ActionResult Create(Customers customer )  //here if we change it's type to customer MVC framework is smart enough 
            //to bind this object to form data as all the key in form data is prefixed with customer. 
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }




        // GET: Customers
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c=>c.MembershipType) .ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer =_context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.ID == id);



            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }




        public ActionResult Edit(int ID)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.ID == ID);

            if (customer == null)
                return HttpNotFound();

            var viewmodel = new CustomerFormViewModel
            {
                Customers = customer,
                MembershipTypes =_context.MembershipTypes.ToList()
            };
            return View("CustomerForm",viewmodel); //Without this view name "New" mvc will look for for a view called Edit.
        }



    }
}