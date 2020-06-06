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
    public class OEMController : ControllerBase
    {
        // GET: api/OEM
        [HttpGet]
        public IEnumerable<string> GetOEMs()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OEM/5
        [HttpGet("{id}", Name = "GetOEM")]
        public string GetOEM(int id)
        {
            return "value";
        }

        // POST: api/OEM
        [HttpPost]
        public void AddOEM([FromBody] string value)
        {
        }

        // PUT: api/OEM/5
        [HttpPut("{id}")]
        public void UpdateOEM(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteOEM(int id)
        {
        }
    }
}
