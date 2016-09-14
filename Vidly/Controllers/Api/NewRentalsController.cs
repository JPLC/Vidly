using System;
using System.Linq;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //POST api/NewRentals
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRentalDto)
        {

            if (newRentalDto.MovieIds.Count == 0)
                return BadRequest("No Movie Ids were given");

            var customer = _context.Customers.
                SingleOrDefault(c => c.Id == newRentalDto.CustomerId);

            if (customer == null)
                return BadRequest("The customer doesn't exist");

            var movies = _context.Movies.Where(m => newRentalDto.MovieIds.Contains(m.Id)
                                                && m.NumberInStock > 0);

            if (movies.Count() != newRentalDto.MovieIds.Count)
                return BadRequest("One or more movie IDs are invalid");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable==0)
                    return BadRequest("Movie is not available");
                movie.NumberAvailable--;
                var rental = new Rental()
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
