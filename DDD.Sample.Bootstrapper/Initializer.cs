using DDD.Sample.Application;
using DDD.Sample.Application.Interfaces;
using DDD.Sample.Domain.IRepository;
using DDD.Sample.Infrastructure;
using DDD.Sample.Infrastructure.Interfaces;
using DDD.Sample.Infrastructure.IoC;
using DDD.Sample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Bootstrapper
{
    public static class Initializer
    {
        public static void Initialize()
        {
            var container = IocUnityContainer.UnityContainer;
            container.RegisterType<IDbContext, StudentDbContext>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<IStudentService, StudentService>();
        }
    }
}
