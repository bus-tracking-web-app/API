using First.CORE.DATA;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.INFRA.SERVICE
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        public void CreateStudent(Student student)
        {
            _studentRepository.CreateStudent(student);
        }

        public void DeleteStudent(int id)
        {
            _studentRepository.DeleteStudent(id);
        }

        public List<Student> GetAllStudent()
        {
            return _studentRepository.GetAllStudent();
        }

        public Student GetAllStudentById(int id)
        {
            return _studentRepository.GetAllStudentById(id);
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student);
        }
    }
}