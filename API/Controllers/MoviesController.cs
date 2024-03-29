using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class MoviesController : BaseApiController
    {
        private readonly DataContext _context;
        public MoviesController(DataContext context)
        {
            _context = context;
        }
        [HttpGet] // api/movies
        public async Task<ActionResult<List<Movie>>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        [HttpGet("{id}")] //api/movies/id

        public async Task<ActionResult<Movie>> GetMovie(Guid id)
        {
            return await _context.Movies.FindAsync(id);
        }
    }
}