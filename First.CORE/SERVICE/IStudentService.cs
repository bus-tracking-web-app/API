using First.CORE.DATA;
using First.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.SERVICE
{
    public interface IStudentService
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
