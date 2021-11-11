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
    [Route("[controller]")]
    [ApiController]
    public class AdultsController : ControllerBase
    {
        private IList<Adult> adults;
        private IFamilyService adultService;

        public AdultsController(IFamilyService adultService)
        {
            this.adultService = adultService;
        }
        
        // GET: Adults
        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults([FromQuery] string? lastname)
        {
            try
            {
                adults = await adultService.GetAdultsAsync();
                if (lastname != null)
                {
                    adults = adults.Where(a => a.LastName == lastname).ToList();
                }


                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        // POST: Adults
        [HttpPost]
        public async Task<ActionResult<Family>> AddAdult([FromBody] Family family)
        {
            try
            {
               await adultService.AddAdultAsync(family);
                return Created($"/{family.Adults[0].FirstName}", family);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        // DELETE: Adults/5
        [HttpDelete]
        [Route("{id:int}")]
        public  async Task<ActionResult<Adult>>  RemoveAdult([FromRoute] int id)
        {
            try
            {
              await  adultService.RemoveAdultAsync(id);
                
                return Ok(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}