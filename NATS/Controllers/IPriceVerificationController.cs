using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace NATS.Controllers
{
    public interface IPriceVerificationController
    {
        void Delete(int id);
        IEnumerable<string> Get();
        string Get(int id);
        void Post([FromBody] string value);
        void Put(int id, [FromBody] string value);
    }
}