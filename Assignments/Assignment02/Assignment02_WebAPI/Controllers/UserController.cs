using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment02_WebAPI.Data;
using Assignment02_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment02_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        
        // GET: User
        [HttpGet]
        public async Task<ActionResult> ValidateUser([FromQuery] string username, [FromQuery] string password)
        {
            try
            {
               userService.ValidateUser(username,password);
               
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}