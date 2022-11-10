using First.CORE.DATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.SERVICE
{
    public interface IAttendanceService
    {
        List<Attendance> GetAllattendance();
        Attendance GetattendanceByStudentId(int id);
        void Createattendance(Attendance attendance);
        void Updateattendance(Attendance attendance);
        void Deleteattendance(int id);
    }
}
