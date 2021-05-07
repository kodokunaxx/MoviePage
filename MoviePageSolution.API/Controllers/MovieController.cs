using Microsoft.AspNetCore.Mvc;
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
        public MovieController(MovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            return Ok(await _movieRepository.getAll());
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
