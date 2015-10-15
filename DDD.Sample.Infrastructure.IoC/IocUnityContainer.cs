using DDD.Sample.Infrastructure.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Infrastructure.IoC
{
    public class IocUnityContainer
    {
        public static UnityContainer UnityContainer = new UnityContainer();

        public void RegisterType<TFrom, TTo>() where TTo : TFrom
        {
            UnityContainer.RegisterType<TFrom, TTo>();
        }

        public T Resolve<T>()
        {
            return UnityContainer.Resolve<T>();
        }
    }
}
