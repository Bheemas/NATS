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
    public class DealerController : ControllerBase
    {
        // GET: api/Dealer
        [HttpGet]
        public IEnumerable<string> GetDealers()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Dealer/5
        [HttpGet("{id}", Name = "GetDealer")]
        public string GetDealer(int id)
        {
            return "value";
        }

        // POST: api/Dealer
        [HttpPost]
        public void AddDealer([FromBody] string value)
        {
        }

        // PUT: api/Dealer/5
        [HttpPut("{id}")]
        public void UpdateDealer(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteDealer(int id)
        {
        }
    }
}
