using System;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {


        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            return View(movie);

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