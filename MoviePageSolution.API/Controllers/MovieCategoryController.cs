using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviePageSolution.Data.Repositories;
using MoviePageSolution.Data.Entities;

namespace MoviePageSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieCategoryController : ControllerBase
    {
        private readonly MovieCategoryRepository _movieCategoryRepository;
        public MovieCategoryController(MovieCategoryRepository movieCategoryRepository)
        {
            _movieCategoryRepository = movieCategoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            return Ok(await _movieCategoryRepository.getAll());
        }

        [HttpGet("{idMovie}")]
        public async Task<IActionResult> getCategoryOfMovie(int? idMovie)
        {
            return Ok(await _movieCategoryRepository.getCategoryOfMovie(idMovie));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> add([FromBody] MovieCategory movieCategory)
        {
            return Ok(await _movieCategoryRepository.add(movieCategory));
        }

        [HttpPost]
        [Route("delete/{movieCategoryID}")]
        public async Task<IActionResult> delete(int? movieCategoryID)
        {
            return Ok(await _movieCategoryRepository.delete(movieCategoryID));
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> update([FromBody] MovieCategory movieCategory)
        {
            await _movieCategoryRepository.update(movieCategory);
            return Ok();
        }
    }
}
