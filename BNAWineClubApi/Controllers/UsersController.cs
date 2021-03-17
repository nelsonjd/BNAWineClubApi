using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BNAWineClubApi.Models;
using System.Net.Mime;

namespace BNAWineClubApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Create(User user)
        {
            if (user.Password == Environment.GetEnvironmentVariable("PASSPHRASE_1")
                || user.Password == Environment.GetEnvironmentVariable("PASSPHRASE_2")
                || user.Password == Environment.GetEnvironmentVariable("PASSPHRASE_3"))
            {
                user.Id = 1;
                return new CreatedResult(new Uri("https://phy53ofxp0.execute-api.us-east-2.amazonaws.com/Prod/api/users/1"), user);
            }

            return Unauthorized();
        }
    }
}
