using First.CORE.DATA;
using First.CORE.DTO;
using System;
using System.Collections.Generic;

namespace First.CORE.REPOSITORY
{
    public interface IAttendanceRepository
    {
        List<AllAttendance> GetAllattendance();
        List<AllAttendance> GetattendanceByStudentId(int id);
        void Createattendance(Attendance attendance);
        void Updateattendance(Attendance attendance);
        void Deleteattendance(int id);
        List<Attendancestatus> GetStatus();
        Attendancestatus GetStatusById(int id);

        List<AllAttendance> GetattendanceByDate(DateTime dateofattendance);
        List<GetParentEmail_Attendance> GetParentEmail(DateTime dateofday);
        List<AllAttendance> Search(SearchAtt searchAtt);
    }
}
