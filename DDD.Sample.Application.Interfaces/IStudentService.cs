using DDD.Sample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Application.Interfaces
{
    public interface IStudentService
    {
        Student Get(int id);

        bool Add(string name);
    }
}
