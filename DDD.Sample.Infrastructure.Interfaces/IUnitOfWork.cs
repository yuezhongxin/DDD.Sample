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
        bool Commit();

        void Rollback();
    }
}
