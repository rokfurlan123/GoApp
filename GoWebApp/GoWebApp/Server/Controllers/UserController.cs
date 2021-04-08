using GoWebApp.Server.Data;
using GoWebApp.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        private readonly HttpContext _httpContext;

        public UserController(DataContext context, HttpContext httpContext)
        {
            _context = context;
            _httpContext = httpContext;
        }

        [HttpGet("GetUser")]
        public async Task<User> GetUserAsync()
        {
            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var user = await _context.Users.FirstOrDefault(x => x.Id == userId);
            return user;
        }


    }
}
