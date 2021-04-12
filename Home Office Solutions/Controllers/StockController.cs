using Home_Office_Solutions.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Home_Office_Solutions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {


        // GET: api/<Stock>
        [HttpGet]
        public List<Stock> Get()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Customers.OrderByDescending(p => p.ProductID).ToList();
        }

        // GET api/<StockController>/5
        [HttpGet("{id}")]
        public Stock Get(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Customers.SingleOrDefault(p => p.StockID == id);
        }
        

        // POST api/<StockController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StockController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StockController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
