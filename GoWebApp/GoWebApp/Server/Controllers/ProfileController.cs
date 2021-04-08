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

namespace GoWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProfileController : ControllerBase
    {
        private readonly DataContext _context;

        public ProfileController(DataContext context)
        {
            _context = context;
           
        }

        private int GetProfileId() => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

        private async Task<User> GetProfile() => await _context.Users.FirstOrDefaultAsync(x => x.Id == GetProfileId());

        [HttpGet("GetProfileInfo")]
        public async Task<IActionResult> GetProfileInfo()
        {
            var user = await GetProfile();
            return Ok(user);
        }
    }
}
