using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Home_Office_Solutions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationaryController : ControllerBase
    {
        // GET: api/<StationaryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StationaryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // GET api/KeyW<Stationary>/5
        [System.Web.Http.HttpGet("KeyW{word}")]
        public IHttpActionResult GetAllcustomersByKeyword(string keyword)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var result = db.Stationary.Where(m => m.Name.Contains(keyword)).Select(m
            => new { m.ProductID, m.Name });
            if (result.Count() == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }
        }

        // POST api/<StationaryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StationaryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StationaryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
