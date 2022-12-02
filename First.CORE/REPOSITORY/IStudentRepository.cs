using First.CORE.DATA;
using First.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.REPOSITORY
{
    public interface IStudentRepository
    {
        List<AllInformationOfStudent> GetAllStudent();
        Student GetAllStudentById(int id);
        //TotalStudent StudentCount();
        int StudentCount();
        void CreateStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}
