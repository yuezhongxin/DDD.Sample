using DDD.Sample.Domain;
using DDD.Sample.Domain.Repository.Interfaces;
using DDD.Sample.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Repository
{
    public abstract class BaseRepository<TAggregateRoot> : IRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        public readonly IQueryable<TAggregateRoot> _entities;

        public BaseRepository(IDbContext dbContext)
        {
            _entities = dbContext.Set<TAggregateRoot>();
        }

        public IQueryable<TAggregateRoot> Get(int id)
        {
            return _entities.Where(t => t.Id == id);
        }

        public IQueryable<TAggregateRoot> GetAll()
        {
            return _entities;
        }
    }
}
