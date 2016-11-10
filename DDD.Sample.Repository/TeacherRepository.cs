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
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(IDbContext dbContext)
            : base(dbContext)
        { }
    }
}
