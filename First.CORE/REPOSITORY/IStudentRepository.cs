using First.CORE.DATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.REPOSITORY
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudent();
        Student GetAllStudentById(int id);
        void CreateStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}
