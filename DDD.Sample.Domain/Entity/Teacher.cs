using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Domain
{
    public class Teacher : IAggregateRoot
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int StudentCount { get; set; }
    }
}
