using DDD.Sample.Application.Interfaces;
using DDD.Sample.Domain;
using DDD.Sample.Infrastructure;
using DDD.Sample.Infrastructure.Interfaces;
using DDD.Sample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityFramework.Extensions;
using DDD.Sample.Domain.Repository.Interfaces;

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

        public async Task<Student> Get(int id)
        {
            return await _studentRepository.Get(id).FirstOrDefaultAsync();
        }

        public async Task<bool> Add(string name)
        {
            var student = new Student { Name = name };
            var teacher = await _teacherRepository.Get(1).FirstOrDefaultAsync();
            teacher.StudentCount++;

            await _unitOfWork.RegisterNew(student);
            await _unitOfWork.RegisterDirty(teacher);
            return await _unitOfWork.CommitAsync();
        }

        public async Task<bool> AddWithTransaction(string name)
        {
            _unitOfWork.BeginTransaction();

            var teacher = new Teacher { Name = "teacher one" };
            await _unitOfWork.RegisterNew(teacher);

            await _unitOfWork.ExecuteSqlCommandAsync("update students set name='xishuai 2'");

            var student = new Student { Name = name, TeacherId = teacher.Id };
            await _unitOfWork.RegisterNew(student);

            return await _unitOfWork.CommitAsync();
        }

        public async Task<bool> UpdateName(int id, string name)
        {
            return await _studentRepository.Get(id)
                .UpdateAsync(x => new Student { Name = name }) > 0;
        }
    }
}
