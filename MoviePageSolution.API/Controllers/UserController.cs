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
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            return Ok(await _userRepository.getAll());
        }

        [HttpGet("{userID}")]
        public async Task<IActionResult> get(int? userID)
        {
            return Ok(await _userRepository.get(userID));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> add([FromBody] User user)
        {
            return Ok(await _userRepository.add(user));
        }

        [HttpPost]
        [Route("delete/{userID}")]
        public async Task<IActionResult> delete(int? userID)
        {
            return Ok(await _userRepository.delete(userID));
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> update([FromBody] User user)
        {
            await _userRepository.update(user);
            return Ok();
        }
    }
}
