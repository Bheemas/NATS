using NATS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NATS.Repository
{
    public class CustomerRepository : Repository<Customers>, ICustomerRepository
    {
        public FrontDoorContext ApplicationDatabaseContext
        {
            get { return DatabaseContext as FrontDoorContext; }
        }

        public CustomerRepository(FrontDoorContext context) : base(context) { }

        public IEnumerable<Customers> GetBooks()
        {
            return ApplicationDatabaseContext.Customers.ToList();
        }

        public IEnumerable<Customers> GetBooksByCurrentYear()
        {
            return ApplicationDatabaseContext.Customers.Where(b => b.LastName != null).ToList();
        }
    }
}
