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
    public class TeacherRepository : ITeacherRepository
    {
        private IQueryable<Teacher> _teachers;

        public TeacherRepository(IDbContext dbContext)
        {
            _teachers = dbContext.Set<Teacher>();
        }

        public Teacher Get(int id)
        {
            return _teachers.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
