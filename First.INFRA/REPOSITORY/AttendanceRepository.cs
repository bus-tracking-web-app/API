using Dapper;
using First.CORE.COMMON;
using First.CORE.DATA;
using First.CORE.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace First.INFRA.REPOSITORY
{
    public class AttendanceRepository: IAttendanceRepository
    {
        private readonly IDbContext _dbContext;

        public AttendanceRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Createattendance(Attendance attendance)
        {
            var p = new DynamicParameters();
            p.Add("Stdid", attendance.Studentid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("BusiD", attendance.Busid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Dofat", attendance.Dateofattendance, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("attState", attendance.Attendancestatus, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("attendance_package.Createattendance", p, commandType: CommandType.StoredProcedure);
        }

        public void Deleteattendance(int id)
        {
            var p = new DynamicParameters();
            p.Add("AId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("attendance_package.Deleteattendance", p, commandType: CommandType.StoredProcedure);
        }

        public List<Attendance> GetAllattendance()
        {
            IEnumerable<Attendance> result = _dbContext.Connection.Query<Attendance>("attendance_package.GetAllattendance", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Attendance GetattendanceByStudentId(int id)
        {
            var p = new DynamicParameters();
            p.Add("SId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Attendance> result = _dbContext.Connection.Query<Attendance>("attendance_package.GetattendanceByStudentId", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Updateattendance(Attendance attendance)
        {
            var p = new DynamicParameters();
            p.Add("AId",attendance.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Stdid", attendance.Studentid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("BusiD", attendance.Busid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Dofat", attendance.Dateofattendance, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("attState", attendance.Attendancestatus, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("attendance_package.Updateattendance", p, commandType: CommandType.StoredProcedure);
        }
    }
}
