using DDD.Sample.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Infrastructure.Interfaces
{
    public interface IDbContext
    {
        Database Database { get; }

        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity)
            where TEntity : class;

        Task<int> SaveChangesAsync();
    }
}
