using Microsoft.AspNetCore.Mvc;
using NATS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NATS.Repository
{
    public interface IPVRepository
    {
      public string Get(int id);
      public IEnumerable<string> Get();
      public void Post([FromBody] string value);
      public void Put(int id, [FromBody] string value);
      public void Delete(int id);

      
    }
}
