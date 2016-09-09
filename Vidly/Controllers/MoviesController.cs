using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        #region Learning
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name="Customer 1"},
                new Customer { Name="Customer 2"},
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            //return new ViewResult();
            //return Content("Hello World");
            // return new EmptyResult();
            //return RedirectToAction("Index","Home", new {page=1, sortdby="name"});

            //ViewData["RandomMovie"] = movie;
            //ViewBag.RandomMovie = movie;

            return View(viewModel);
        }

        // GET: Movies/Edit/{id}
        public ActionResult Edit(int id)
        {
            return Content("Id:" + id);
        }

        // GET: Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (sortBy.IsNullOrWhiteSpace())
            {
                sortBy = "Name";
            }
            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        
        // GET: Movies/released/{year}/{month}
        [Route("movies/released/{year}/{month:regex(\\d{2}):range:(1,12)}")]
        public ActionResult ByReleaseDate(int year, string month)
        {
            return Content(year + "/" + month);
        }
        #endregion
    }
}