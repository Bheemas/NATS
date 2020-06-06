using NATS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NATS.Repository
{
    public interface ICustomerRepository : IRepository<Customers>
    {
        IEnumerable<Customers> GetBooks();
        IEnumerable<Customers> GetBooksByCurrentYear();
    }
}
