using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviePageSolution.Data.EF;
using MoviePageSolution.Data.Entities;
using MoviePageSolution.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePageSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieRepository _movieRepository;
        private MoviePageDbContext _context;
        public MovieController(MovieRepository movieRepository,MoviePageDbContext context)
        {
            _movieRepository = movieRepository;
            _context = context;
        }
        [HttpGet]
        [Route("search")]
        public async Task<IActionResult> Index(string keyword)
        {
            var movies = from m in _context.Movies
                         select new  { 
                            m.Id,
                            m.Title,
                            m.Time,
                            m.Poster
                         };

            if (!String.IsNullOrEmpty(keyword))
            {
                movies = movies.Where(s => s.Title.Contains(keyword));
            }

            return Ok(await movies.ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> getAll(int? categoryID = null)
        {
            return Ok(await _movieRepository.getAll(categoryID));
        }

        [HttpGet("{movieID}")]
        public async Task<IActionResult> get(int? movieID)
        {
            return Ok(await _movieRepository.get(movieID));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> add([FromBody] Movie movie)
        {
            return Ok(await _movieRepository.add(movie));
        }

        [HttpPost]
        [Route("delete/{movieID}")]
        public async Task<IActionResult> delete(int? movieID)
        {
            return Ok(await _movieRepository.delete(movieID));
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> update([FromBody] Movie movie)
        {
            await _movieRepository.update(movie);
            return Ok();
        }
    }
}
