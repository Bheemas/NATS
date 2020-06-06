using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ActionFilters.ActionFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NATS.Models;
using NATS.Repository;

namespace NATS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceVerificationController : ControllerBase, IPVRepository
    {
        // Logger
        private readonly ILogger _logger;
        private IPVRepository _repository;

        public PriceVerificationController(ILogger<PriceVerificationController> logger, IPVRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        // GET: api/PriceVerification
        [HttpGet]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public IEnumerable<string> Get()
        {
            var result = _repository.Get();
            return result;
                
        }

        // GET: api/PriceVerification/5
        [HttpGet("{id}", Name = "Get")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public string Get(int id)
        {
            string message = "";            
            message = _repository.Get(id);
            return message;
        }


        // POST: api/PriceVerification
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PriceVerification/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        #region customers

      
    #endregion

}
}
