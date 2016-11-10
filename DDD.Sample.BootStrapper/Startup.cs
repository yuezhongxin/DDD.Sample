using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.BootStrapper
{
    public class Startup
    {
        public static void Configure()
        {
            //configure ioc

            ConfigureMapper();
        }

        private static void ConfigureMapper()
        {
            //configure automapper dtos
        }
    }
}
