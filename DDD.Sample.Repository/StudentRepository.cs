using DDD.Sample.Domain;
using DDD.Sample.Domain.Repository.Interfaces;
using DDD.Sample.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Repository
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        public IQueryable<Student> GetByName(string name)
        {
            return _entities.Where(x => x.Name == name);
        }
    }
}
