using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NATS.Models
{
    public class ErrorModel
    {

        public int StatusCode {get;set;}
        public string ErrorMessage { get; set; }


    }
}
