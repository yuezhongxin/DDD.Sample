using DDD.Sample.Domain;
using DDD.Sample.Domain.IRepository;
using DDD.Sample.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Repository
{
    public abstract class BaseRepository<TAggregateRoot> : IRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        public readonly IDbContext _dbContext;

        public BaseRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TAggregateRoot Get(int id)
        {
            return _dbContext.Set<TAggregateRoot>().FirstOrDefault(t => t.Id == id);
        }
    }
}
