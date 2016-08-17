using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomers();

            var viewModel = new CustomersViewModel()
            {
                Customers = customers.ToList()
            };

            return View(viewModel);

        }

        public ActionResult Details(int id )
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

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


       

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer() {Id = 1, Name = "John Smith", Age = 54},
                new Customer() {Id = 2, Name = "Jane Simmons", Age = 34}
            };
        }



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