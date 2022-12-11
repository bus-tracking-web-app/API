using First.CORE.DATA;
using First.CORE.DTO;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using System;
using System.Collections.Generic;

namespace First.INFRA.SERVICE
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _attendaneRepository;
        public AttendanceService(IAttendanceRepository attendaneRepository)
        {
            _attendaneRepository = attendaneRepository;
        }

        public void Createattendance(Attendance attendance)
        {
            _attendaneRepository.Createattendance(attendance);
        }

        public void Deleteattendance(int id)
        {
            _attendaneRepository.Deleteattendance(id);
        }

        public List<AllAttendance> GetAllattendance()
        {
            return _attendaneRepository.GetAllattendance();
        }

         public List<AllAttendance> GetattendanceByStudentId(int id)
        {
            return _attendaneRepository.GetattendanceByStudentId(id);
        }

        public List<Attendancestatus> GetStatus()
        {
            return _attendaneRepository.GetStatus();
        }

        public Attendancestatus GetStatusById(int id)
        {
            return _attendaneRepository.GetStatusById(id);
        }

        public void Updateattendance(Attendance attendance)
        {
            _attendaneRepository.Updateattendance(attendance);
        }
        public List<AllAttendance> GetattendanceByDate(DateTime dateofattendance)
        {
            return _attendaneRepository.GetattendanceByDate(dateofattendance);
        }

        public List<GetParentEmail_Attendance> GetParentEmail(DateTime dateofday)
        {
            return _attendaneRepository.GetParentEmail(dateofday);
        }

        public List<AllAttendance> Search(SearchAtt searchAtt)
        {
            return _attendaneRepository.Search( searchAtt);
        }
    }
}
