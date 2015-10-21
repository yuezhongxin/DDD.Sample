using DDD.Sample.Application.Interfaces;
using DDD.Sample.Domain;
using DDD.Sample.Domain.IRepository;
using DDD.Sample.Infrastructure;
using DDD.Sample.Infrastructure.Interfaces;
using DDD.Sample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Application
{
    public class StudentService : IStudentService
    {
        private IDbContext _dbContext;
        private IUnitOfWork _unitOfWork;
        private IStudentRepository _studentRepository;
        private ITeacherRepository _teacherRepository;

        public StudentService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Student Get(int id)
        {
            _studentRepository = new StudentRepository(_dbContext);
            return _studentRepository.Get(id);
        }

        public bool Add(string name)
        {
            _unitOfWork = new UnitOfWork(_dbContext);
            _studentRepository = new StudentRepository(_dbContext);
            _teacherRepository = new TeacherRepository(_dbContext);

            var student = new Student { Name = name };
            var teacher = _teacherRepository.Get(1);
            teacher.StudentCount++;

            _studentRepository.Add(student);
            _teacherRepository.Update(teacher);
            return _unitOfWork.Commit();
        }
    }
}
