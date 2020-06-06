using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class Addresses
    {
        public int AddressId { get; set; }
        public int CustomerId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public virtual Customers Address { get; set; }
    }
}
