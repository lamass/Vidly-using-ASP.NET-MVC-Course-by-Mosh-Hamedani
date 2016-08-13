using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // generic routes are listed after specific routes

            // allows custom route attribute routing
            routes.MapMvcAttributeRoutes();



            // ROUTE BELOW IS AN OLDER CONVENTION, MAY STILL BE USED IN LEGACY CODE ********************
            // custom route
            // action created in MoviesController
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    // anonymous object
            //    new { controller = "Movies", action = "ByReleaseDate"},
            //    // constraints the year and month entered into url to 4 and 2 digits respectively
            //    new { year = @"\d{4}", month = @"\d{2}" });



            // default generic route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
