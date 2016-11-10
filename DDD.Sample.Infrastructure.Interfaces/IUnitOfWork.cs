using DDD.Sample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        void BeginTransaction();

        Task<int> ExecuteSqlCommandAsync(string sql, params object[] parameters);

        Task<bool> RegisterNew<TEntity>(TEntity entity)
            where TEntity : class;

        Task<bool> RegisterDirty<TEntity>(TEntity entity)
            where TEntity : class;

        Task<bool> RegisterClean<TEntity>(TEntity entity)
            where TEntity : class;

        Task<bool> RegisterDeleted<TEntity>(TEntity entity)
            where TEntity : class;

        Task<bool> CommitAsync();

        void Rollback();
    }
}
