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
        Task<Student> Get(int id);

        Task<bool> Add(string name);

        Task<bool> AddWithTransaction(string name);

        Task<bool> UpdateName(int id, string name);
    }
}
