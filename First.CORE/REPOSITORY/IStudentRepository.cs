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
        List<Student> GetStudentByBusId(int Bus_ID);
        List<Student> GetStudentByParentId(int Parent_ID);

        Student GetAllStudentById(int id);
        void CreateStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
        void UpdateStudentBusStatus(string lathome);
        void UpdateAllStudentStatus();
        List<ParentStudentDTO> getParentStudents(int id);



    }
}
