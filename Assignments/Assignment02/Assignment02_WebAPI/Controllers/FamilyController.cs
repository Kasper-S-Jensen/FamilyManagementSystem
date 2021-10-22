#nullable enable
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
        private IList<Adult> adults;
        private IList<Child> children;

        public FamilyController(IAdultData familyData)
        {
            this.familyData = familyData;
        }

        // GET: Family
        [HttpGet]
        public async Task<ActionResult<IList<Family>>> GetFamilies([FromQuery] string? streetName, [FromQuery] int? houseNumber)
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
        
        // GET: Family
        [HttpGet]
        public async Task<ActionResult<IList<Family>>> GetAdults([FromQuery] string? lastname)
        {
            try
            {
                adults = familyData.GetAdults();
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
        
        // GET: Family
        [HttpGet]
        public async Task<ActionResult<IList<Family>>> GetChildren([FromQuery] string? lastname)
        {
            try
            {
                children = familyData.GetChildren();
                if (lastname != null)
                {
                    children = children.Where(c => c.LastName == lastname).ToList();
                }

                return Ok(children);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        // POST: Family
        [HttpPost]
        public async Task<ActionResult<Family>> AddFamily([FromBody] string streetName, [FromBody] int houseNumber)
        {
            try
            {
                Family toAdd = new Family()
                {
                    StreetName = streetName,
                    HouseNumber = houseNumber
                };
                familyData.AddFamily(streetName,houseNumber);
                return Created($"/{toAdd.StreetName}", toAdd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        // POST: Family
        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] string streetName, [FromBody] int houseNumber)
        {
            try
            {
                Family toAdd = new Family()
                {
                    StreetName = streetName,
                    HouseNumber = houseNumber
                };
                familyData.AddFamily(streetName,houseNumber);
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
        [HttpDelete("{id}")]
        public void RemoveFamily(int id)
        {
        }
        
        // DELETE: Family/5
        [HttpDelete("{id}")]
        public void RemoveAdult(int id)
        {
        }
    }
}
