using NATS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NATS.Repository
{
    public abstract class Repository<TModel> : IRepository<TModel> where TModel : class
    {
        protected readonly FrontDoorContext DatabaseContext;

        public Repository(FrontDoorContext context)
        {
            this.DatabaseContext = context;
        }

        public void Add(TModel entity)
        {
            DatabaseContext.Set<TModel>().Add(entity);
        }

        public TModel Get(int id)
        {
            return DatabaseContext.Set<TModel>().Find(id);
        }

        public IEnumerable<TModel> GetAll()
        {
            return DatabaseContext.Set<TModel>().ToList();
        }

        public void Remove(TModel entity)
        {
            DatabaseContext.Set<TModel>().Remove(entity);
        }
    }

}
