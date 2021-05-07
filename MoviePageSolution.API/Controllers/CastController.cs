using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviePageSolution.Data.Repositories;
using MoviePageSolution.Data.Entities;

namespace CastPageSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastController : ControllerBase
    {
        private readonly CastRepository _castRepository;
        public CastController(CastRepository CastRepository)
        {
            _castRepository = CastRepository;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            return Ok(await _castRepository.getAll());
        }

        [HttpGet("{castID}")]
        public async Task<IActionResult> get(int? castID)
        {
            return Ok(await _castRepository.get(castID));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> add([FromBody] Cast cast)
        {
            return Ok(await _castRepository.add(cast));
        }

        [HttpPost]
        [Route("delete/{castID}")]
        public async Task<IActionResult> delete(int? castID)
        {
            return Ok(await _castRepository.delete(castID));
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> update([FromBody] Cast cast)
        {
            await _castRepository.update(cast);
            return Ok();
        }
    }
}
