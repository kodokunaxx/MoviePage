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
    public class HistoryController : ControllerBase
    {
        private readonly HistoryRepository _historyRepository;
        public HistoryController(HistoryRepository historyRepository)
        {
            _historyRepository = historyRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _historyRepository.getAll());
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> add([FromBody] History history)
        {
            return Ok(await _historyRepository.add(history));
        }

        [HttpPost]
        [Route("delete/{historyID}")]
        public async Task<IActionResult> delete(int? historyID)
        {
            return Ok(await _historyRepository.delete(historyID));
        }

    }
}
