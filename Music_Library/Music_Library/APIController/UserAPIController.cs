using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Music_Library.DTO;

namespace Music_Library.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserAPIController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        // GET: api/UserAPI/GetUsers
        [HttpGet("GetUsers")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            var users = _userManager.Users.ToList(); // Fetching users from UserManager
            var userDtos = users.Select(user => new UserDto
            {
                Id = user.Id, // Use user.Id since IdentityUser has Id as the primary key
                UserName = user.UserName,
                Email = user.Email
            }).ToList();

            return Ok(userDtos);
        }

        // POST: api/UserAPI/Create
        [HttpPost("Create")]
        public async Task<ActionResult> CreateUser([FromBody] CreateUserDto createUserDto)
        {
            var user = new IdentityUser
            {
                UserName = createUserDto.UserName,
                Email = createUserDto.Email
            };

            var result = await _userManager.CreateAsync(user, createUserDto.Password);

            if (result.Succeeded)
                return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
            else
                return BadRequest(result.Errors.Select(e => e.Description)); // Return a user-friendly error message
        }

        // DELETE: api/UserAPI/Delete/{id}
        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
                return NotFound();

            var result = await _userManager.DeleteAsync(user);

            if (result.Succeeded)
                return NoContent();
            else
                return BadRequest(result.Errors.Select(e => e.Description)); // Return a user-friendly error message
        }

        // POST: api/UserAPI/Update
        [HttpPost("Update")]
        public async Task<ActionResult> UpdateUser([FromBody] UpdateUserDto updateUserDto)
        {
            var user = await _userManager.FindByIdAsync(updateUserDto.ID);

            if (user == null)
                return NotFound();

            user.UserName = updateUserDto.UserName;
            user.Email = updateUserDto.Email;

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
                return NoContent();
            else
                return BadRequest(result.Errors.Select(e => e.Description)); // Return a user-friendly error message
        }
    }
}
