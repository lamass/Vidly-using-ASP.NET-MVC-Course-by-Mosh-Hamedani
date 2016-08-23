using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Configuration;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // declare DbContext variable
        private ApplicationDbContext _context;

        // class constructor creates instance of DbContext for variable _context
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            var viewModel = new MoviesViewModel()
            {
                Movies = movies
            };

            return View(viewModel);
        }

        public ActionResult MovieDetails(int? id)
        {
            if (id == null)
            {
                return Content("No customers were selected");
            }

            // retreive Customers model via DbContext
            // .Include() method is used for eager loading.  Includes related data type 'MembershipType'
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(m => m.Id == id);

            var viewModel = new MovieDetailViewModel()
            {
                Movie = movie
            };

            if (movie == null)
                //return HttpNotFound();
                return Content("The selected movie has not been found!");

            // return View(customer);
            return View(viewModel);
        }
















        //private IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie>
        //    {
        //        new Movie {Id = 1, Name = "Shrek"},
        //        new Movie {Id = 2, Name = "Pulp Fiction"}
        //    };
        //}


        // GET: Movies/Random
        // using a viewModel so that the view can access both Movie and Customer models.
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            // list of customer objects
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            // RandomMovieViewModel allows access to multiple models for the View 'Random.cshtml' 
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
           
           
            return View(viewModel);

        }

        //mvcaction4 (then hit tab) creates Action()
        // Legacy MapRoute for ByReleaseDate located in RouteConfig
        // attribute passes arguments for MapMvcAttributes in RouteConfig
        [Route("movies/released/{year:regex(\\d{4}):range(1800, 2999)}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }




























        // EXAMPLES BELOW, MAY DELETE LATER ***********************************************************************

        //public ActionResult Edit(int id)
        //{
        //    return Content("Id=" + id);
        //}

        //// movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    // returns default page number and sorting if arguments are not given.

        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

    }
}