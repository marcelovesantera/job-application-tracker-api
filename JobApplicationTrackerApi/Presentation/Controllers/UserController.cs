using JobApplicationTrackerApi.Domain;
using Microsoft.AspNetCore.Mvc;
using JobApplicationTrackerApi.Infrastructure.Interfaces;
using JobApplicationTrackerApi.Presentation.Models;

namespace JobApplicationTrackerApi.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userRepository.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userRepository.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserInputModel user)
        {
            var userId = _userRepository.AddUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = userId }, user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _userRepository.UpdateUser(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
            return NoContent();
        }
    }
}
