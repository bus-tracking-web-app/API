using First.CORE.DATA;
using First.CORE.DTO;
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

        public List<AllInformationOfStudent> GetAllStudent()
        {
            return _studentRepository.GetAllStudent();
        }

        public Student GetAllStudentById(int id)
        {
            return _studentRepository.GetAllStudentById(id);
        }

        public List<Student> GetStudentByBusId(int Bus_ID)
        {
            return _studentRepository.GetStudentByBusId(Bus_ID);

        }

        public List<Student> GetStudentByParentId(int Parent_ID)
        {
            return _studentRepository.GetStudentByParentId(Parent_ID);
                
        }


        public void UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student);
        }
        public void UpdateStudentBusStatus(string lathome)
        {
            _studentRepository.UpdateStudentBusStatus(lathome);

        }
        public void UpdateAllStudentStatus()
        {
            _studentRepository.UpdateAllStudentStatus();
        }

        public List<ParentStudentDTO> getParentStudents(int id)
        {
            return _studentRepository.getParentStudents(id);
        }
    }
}