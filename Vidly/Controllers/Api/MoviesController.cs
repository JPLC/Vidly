using System;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //GET api/movies
        public IHttpActionResult GetMovies()
        {
            var movieDtos = _context.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>);
            return Ok(movieDtos);
        }

        //GET api/movies/{id}
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        //POST api/movies
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();
            movieDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

        //PUT api/movies/{id}
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movieInDd = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDd == null)
                return NotFound();

            Mapper.Map(movieDto, movieInDd);

            _context.SaveChanges();

            return Ok();
        }

        //PUT api/movies/{id}
        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movieInDd = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movieInDd == null)
                return NotFound();

            _context.Movies.Remove(movieInDd);
            _context.SaveChanges();
            return Ok();
        }
    }
}
