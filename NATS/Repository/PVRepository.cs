using Microsoft.AspNetCore.Mvc;
using NATS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace NATS.Repository
{
    public class PVRepository : IPVRepository
    {
        private readonly FrontDoorContext _context;
        
        public PVRepository()
        {
            _context = new FrontDoorContext();
        }

        public string Get(int id)
        {
            string message = "";
            if (id <= 0)
            {
                message = "Price is not valid.Please recheck.";
              //  _logger.LogInformation(message);
            }

            else
                message = "Verified Price successfully.Please go ahead.";

            return message;
        }
        public IEnumerable<string> Get()
        {
            return new string[] {"testing1","testing2", "testing" };
        }
        public void Post([FromBody] string value)
        {

        }
        public void Put(int id, [FromBody] string value)
        {

        }
        public void Delete(int id)
        {

        }

        // Entities
      
     
      
    }
}
