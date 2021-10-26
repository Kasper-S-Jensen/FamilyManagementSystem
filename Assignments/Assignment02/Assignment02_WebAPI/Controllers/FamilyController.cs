
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
    public class FamilyController : ControllerBase
    {
        private IAdultData familyData;

        private IList<Family> families;
     
        private IList<Child> children;

        public FamilyController(IAdultData familyData)
        {
            this.familyData = familyData;
        }

        // GET: Family
        [HttpGet]
        public async Task<ActionResult<IList<Family>>> GetFamilies([FromQuery] string? streetName,
            [FromQuery] int? houseNumber)
        {
            try
            {
                families = familyData.GetFamilies();
                if (streetName != null)
                {
                    families = families.Where(f => f.StreetName == streetName).ToList();
                }

                if (houseNumber != null)
                {
                    families = families.Where(f => f.HouseNumber == houseNumber).ToList();
                }

                return Ok(families);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
     
        

        // POST: Family
        [HttpPost]
        public async Task<ActionResult<Family>> AddFamily([FromQuery] string streetName, [FromQuery] int houseNumber)
        {
            try
            {
                Family toAdd = new Family()
                {
                    StreetName = streetName,
                    HouseNumber = houseNumber
                };
                familyData.AddFamily(streetName, houseNumber);
                return Created($"/{toAdd.StreetName}", toAdd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

      

        // PUT: Family/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
            
        }

        // DELETE: Family/5
        [HttpDelete]
       
        public async Task<ActionResult<Family>>  RemoveFamily([FromQuery]string streetName,[FromQuery] int houseNumber)
        {
            try
            {
                familyData.RemoveFamily(streetName,houseNumber);
                
                return StatusCode(999, "removed family with streetname: " + streetName + " and housenumber: "+houseNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

      
    }
}