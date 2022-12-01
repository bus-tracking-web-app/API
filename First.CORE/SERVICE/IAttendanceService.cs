using First.CORE.DATA;
using First.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.SERVICE
{
    public interface IAttendanceService
    {
        List<AllAttendance> GetAllattendance();
        Attendance GetattendanceByStudentId(int id);
        void Createattendance(Attendance attendance);
        void Updateattendance(Attendance attendance);
        void Deleteattendance(int id);
        List<Attendancestatus> GetStatus();
        Attendancestatus GetStatusById(int id);
    }
}
