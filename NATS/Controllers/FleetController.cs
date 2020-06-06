using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NATS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FleetController : ControllerBase
    {
        // GET: api/Fleet
        [HttpGet]
        public IEnumerable<string> GetAllFleet()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Fleet/5
        [HttpGet("{id}", Name = "GetFleet")]
        public string GetFleet(int id)
        {
            return "value";
        }

        // POST: api/Fleet
        [HttpPost]
        public void AddFleet([FromBody] string value)
        {
        }

        // PUT: api/Fleet/5
        [HttpPut("{id}")]
        public void UpdateFleet(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteFleet(int id)
        {
        }
    }
}
