using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BNAWineClubApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BNAWineClubApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomePageController : ControllerBase
    {
        // GET: api/<WelcomePageController>
        [HttpGet]
        public WelcomePage Get()
        {
            return new WelcomePage {
                Description = "Welcome to the Nashville Wine Club",
                RegularButtonText = "Regular Entrance",
                VIPButtonText = "V.I.P. Entrance"
            };
        }
    }
}
