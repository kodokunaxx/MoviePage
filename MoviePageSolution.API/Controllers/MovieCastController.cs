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
    public class MovieCastController : ControllerBase
    {
        private readonly MovieCastRepository _movieCastRepository;
        public MovieCastController(MovieCastRepository movieCastRepository)
        {
            _movieCastRepository = movieCastRepository;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            return Ok(await _movieCastRepository.getAll());
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> add([FromBody] MovieCast movieCast)
        {
            return Ok(await _movieCastRepository.add(movieCast));
        }

        [HttpPost]
        [Route("delete/{movieCastID}")]
        public async Task<IActionResult> delete(int? movieCastID)
        {
            return Ok(await _movieCastRepository.delete(movieCastID));
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> update([FromBody] MovieCast movieCast)
        {
            await _movieCastRepository.update(movieCast);
            return Ok();
        }
    }
}
