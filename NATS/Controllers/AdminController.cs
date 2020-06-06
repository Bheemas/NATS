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
    public class AdminController : ControllerBase
    {
        // GET: api/Admin
        [HttpGet]
        [Route("AllUsers")]
        public IEnumerable<string> GetUsers()
        {
            return new string[] { "Tom", "Gary" };
        }

        // GET: api/Admin/5
        [HttpGet("{id}", Name = "GetUser")]
        public string GetUser(int id)
        {
            return "Ravi";
        }

        // POST: api/Admin
        [HttpPost]
        public void AddUser([FromBody] string value)
        {
        }

        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public void UpdateUser(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
        }
    }
}
