using First.CORE.DATA;
using First.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.REPOSITORY
{
    public interface IAttendanceRepository
    {
        List<AllAttendance> GetAllattendance();
        Attendance GetattendanceByStudentId(int id);
        void Createattendance(Attendance attendance);
        void Updateattendance(Attendance attendance);
        void Deleteattendance(int id);
        List<Attendancestatus> GetStatus();
        Attendancestatus GetStatusById(int id);

        List <Attendance> GetattendanceByDate(DateTime dateofattendance);
    }
}
