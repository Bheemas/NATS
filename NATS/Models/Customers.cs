using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class Customers
    {
        public Customers()
        {
            CarsSold = new HashSet<CarsSold>();
            CustomerPreferences = new HashSet<CustomerPreferences>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual Addresses Addresses { get; set; }
        public virtual ICollection<CarsSold> CarsSold { get; set; }
        public virtual ICollection<CustomerPreferences> CustomerPreferences { get; set; }
    }
}
