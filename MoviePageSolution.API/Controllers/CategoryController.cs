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
    public class CategoryController : ControllerBase
    {
        private readonly CategoryRepository _categoryRepository;
        public CategoryController(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            return Ok(await _categoryRepository.getAll());
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> add([FromBody] Category category)
        {
            return Ok(await _categoryRepository.add(category));
        }

        [HttpPost]
        [Route("delete/{categoryID}")]
        public async Task<IActionResult> delete(int? categoryID)
        {
            return Ok(await _categoryRepository.delete(categoryID));
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> update([FromBody] Category category)
        {
            await _categoryRepository.update(category);
            return Ok();
        }
    }
}
