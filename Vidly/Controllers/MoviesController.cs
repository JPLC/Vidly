using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Movies
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre);
            return View(movies.ToList());
        }

        // GET: Movies/{Id}
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var moviewViewModel = new MovieFormViewModel
            {
                Genres = genres
            };
            return View("MovieForm",moviewViewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDd = _context.Movies.Single(c => c.Id == movie.Id);
                //properties to update

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
    }
}