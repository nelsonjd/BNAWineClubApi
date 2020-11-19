using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BNAWineClubApi.Models;

namespace BNAWineClubApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (user.Password =="buddy")
            {
                return CreatedAtAction("GetUser", new { id = 1 }, user);
            }

            return Unauthorized();
        }
    }
}
