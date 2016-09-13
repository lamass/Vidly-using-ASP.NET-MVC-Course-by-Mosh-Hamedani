using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // allows access to database
        private ApplicationDbContext _context;

        // initialize ApplicationDbContext in CustomersController Constructor
        // test note for git
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // dispose of ApplicaitonDbContext
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // Controller for New.cshtml
        public ActionResult New()
        {
            // added DbSet MembershipTypes to IdentityModels.ApplicationDbContext
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
               MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }

        public ViewResult Index()
        {
            // retreive Customers model via DbContext
            // Include method is used for 'eager loading' to include the MembershipType property (and cooresponding class)
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            var viewModel = new CustomersViewModel()
            {
                Customers = customers
            };

            return View(viewModel);

        }

       
        public ActionResult Details(int? id, MembershipType membershipType )
        {
            if (id == null)
            {
                return Content("No customers were selected");
            }

            // retreive Customers model via DbContext
                // .Include() method is used for eager loading.  Includes related data type 'MembershipType'
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            
            var viewModel = new DetailsViewModel()
            {
                CustomerDetail = customer
            };

            if (customer == null)
                //return HttpNotFound();
                return Content("No customers have been found!");

           // return View(customer);
            return View(viewModel);
        }
















        //***************************** OLD CODE ********************************************************

       
        // method GetCustomers() is no longer being used*************************
        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer() {Id = 1, Name = "John Smith", Age = 54},
        //        new Customer() {Id = 2, Name = "Jane Simmons", Age = 34}
        //    };
        //}



        //public ActionResult CustomerList()
        //{
        //    var customers = new List<Customer>
        //    {
        //        new Customer {Name = "John Doe", Age = 19, Id = 1},
        //        new Customer {Name = "Jane Smith", Age = 37, Id = 2}
        //    };

        //   

        //    var viewModel = new CustomersViewModel()
        //    {
        //        Customers = customers
        //    };


        //    return View(viewModel);
        //}


    }
}