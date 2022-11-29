using First.CORE.DATA;
using First.CORE.DTO;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.INFRA.SERVICE
{
    public class AttendanceService: IAttendanceService
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
         return  _attendaneRepository.GetAllattendance();
        }

        public Attendance GetattendanceByStudentId(int id)
        {
            return _attendaneRepository.GetattendanceByStudentId(id);
        }

        public void Updateattendance(Attendance attendance)
        {
           _attendaneRepository.Updateattendance(attendance);
        }
    }
}
