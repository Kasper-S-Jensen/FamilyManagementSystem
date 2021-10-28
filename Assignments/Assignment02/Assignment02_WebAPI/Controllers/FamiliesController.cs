
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
    public class FamiliesController : ControllerBase
    {
        private IFamilyData familyData;

        private IList<Family> families;
     
        private IList<Child> children;

        public FamiliesController(IFamilyData familyData)
        {
            this.familyData = familyData;
        }

        // GET: Families
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
     
        

        // POST: Families
        [HttpPost]
        public async Task<ActionResult<Family>> AddFamily([FromBody] Family family)
        {
            try
            {
              
                familyData.AddFamily(family);
                return Created($"/{family.StreetName}", family);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

      

        // PUT: Families/5
        [HttpPut("{streetName}/{houseNumber:int}")]
        public async Task<ActionResult<Family>> UpdateFamily( [FromBody] Family family)
        {
            try
            {
                familyData.Update(family);
                return Created($"/{family.StreetName}/{family.HouseNumber}", family);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        // DELETE: Families/5
        [HttpDelete("{streetName}/{houseNumber:int}")]
        public async Task<ActionResult<Family>>  RemoveFamily([FromRoute]string streetName,[FromRoute] int houseNumber)
        {
            try
            {
                familyData.RemoveFamily(streetName,houseNumber);
                
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