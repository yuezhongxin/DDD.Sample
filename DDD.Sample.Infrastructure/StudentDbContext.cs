using DDD.Sample.Domain;
using DDD.Sample.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Infrastructure
{
    public class SchoolDbContext : DbContext, IDbContext
    {
        public SchoolDbContext()
            : base("name=db_school")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>();
            modelBuilder.Entity<Teacher>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
