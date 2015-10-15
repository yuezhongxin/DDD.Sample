using DDD.Sample.Application;
using DDD.Sample.Application.Interfaces;
using DDD.Sample.Domain.IRepository;
using DDD.Sample.Infrastructure;
using DDD.Sample.Infrastructure.Interfaces;
using DDD.Sample.Repository;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DDD.Sample.Tests
{
    public class StudentServiceTest
    {
        private IStudentService _studentService;

        public StudentServiceTest()
        {
            var container = new UnityContainer();
            container.RegisterType<IDbContext, SchoolDbContext>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<ITeacherRepository, TeacherRepository>();
            container.RegisterType<IStudentService, StudentService>();

            _studentService = container.Resolve<IStudentService>();
        }

        [Fact]
        public void GetByIdTest()
        {
            var student = _studentService.Get(1);
            Assert.NotNull(student);
        }

        [Fact]
        public void AddTest()
        {
            var result = _studentService.Add("xishuai");
            Assert.True(result);
        }
    }
}
