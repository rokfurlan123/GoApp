using GoWebApp.Server.Data;
using GoWebApp.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetUser")]
        public async Task<IActionResult> GetUser()
        {
            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody]User profile)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == profile.Id);

            user.Username = profile.Username;
            user.Email = profile.Email;
            user.DateOfBirth = profile.DateOfBirth;
            if (profile.Img != null)
            {
                user.Img = profile.Img;
            }
            await _context.SaveChangesAsync();
            return Ok();
        }

        //private int GetProfileId() => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

        //private async Task<User> GetProfile() => await _context.Users.FirstOrDefaultAsync(x => x.Id == GetProfileId());

        //[HttpGet("GetProfileInfo")]
        //public async Task<IActionResult> GetProfileInfo()
        //{
        //    var user = await GetProfile();
        //    return Ok(user);
        //}

    }
}
