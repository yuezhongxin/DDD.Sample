using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Domain.IRepository
{
    public interface IRepository<TAggregateRoot> 
        where TAggregateRoot : class, IAggregateRoot
    {
        void Add(TAggregateRoot aggregateRoot);

        void Update(TAggregateRoot aggregateRoot);

        void Delete(TAggregateRoot aggregateRoot);

        TAggregateRoot Get(int id);
    }
}
