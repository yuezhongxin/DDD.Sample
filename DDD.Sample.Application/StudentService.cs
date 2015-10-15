using DDD.Sample.Application.Interfaces;
using DDD.Sample.Domain;
using DDD.Sample.Domain.IRepository;
using DDD.Sample.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Application
{
    public class StudentService : IStudentService
    {
        private IUnitOfWork _unitOfWork;
        private IStudentRepository _studentRepository;
        private ITeacherRepository _teacherRepository;

        public StudentService(IUnitOfWork unitOfWork, 
            IStudentRepository studentRepository,
            ITeacherRepository teacherRepository)
        {
            _unitOfWork = unitOfWork;
            _studentRepository = studentRepository;
            _teacherRepository = teacherRepository;
        }

        public Student Get(int id)
        {
            return _studentRepository.Get(id);
        }

        public bool Add(string name)
        {
            var student = new Student { Name = name };
            var teacher = _teacherRepository.Get(1);
            teacher.StudentCount++;

            _unitOfWork.RegisterNew(student);
            _unitOfWork.RegisterDirty(teacher);
            return _unitOfWork.Commit();
        }
    }
}
