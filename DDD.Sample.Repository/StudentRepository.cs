using DDD.Sample.Domain;
using DDD.Sample.Domain.IRepository;
using DDD.Sample.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Repository
{
    public class StudentRepository: IStudentRepository
    {
        private IQueryable<Student> _students;

        public StudentRepository(IDbContext dbContext)
        {
            _students = dbContext.Set<Student>();
        }

        public Student Get(int id)
        {
            return _students.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
