using Dapper;
using First.CORE.COMMON;
using First.CORE.DATA;
using First.CORE.DTO;
using First.CORE.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace First.INFRA.REPOSITORY
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IDbContext _dbContext;

        public StudentRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateStudent(Student student)
        {
            var p = new DynamicParameters();
            p.Add("fullname", student.Fullname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMGPATH", student.Imgpath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("XHOME", student.Xhome, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("YHOME", student.Yhome, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("INBUSSTATUS", student.Inbusstatus, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ROUND", student.Round, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("PARENTID", student.Parentid, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("BUSID", student.Busid, dbType: DbType.Decimal, direction: ParameterDirection.Input);
           
            _dbContext.Connection.Execute("STUDENT_Package.CreateStudent", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteStudent(int id)
        {
            var p = new DynamicParameters();
            p.Add("STUDENT_id", id, DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Student> result = _dbContext.Connection.Query<Student>("STUDENT_Package.DeleteStudent", p, commandType: CommandType.StoredProcedure);
        }

        public List<AllInformationOfStudent> GetAllStudent()
        {
            IEnumerable<AllInformationOfStudent> result = _dbContext.Connection.Query<AllInformationOfStudent>("STUDENT_Package.GetAllStudent", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public int StudentCount()
        {
 
            IEnumerable<int> result = _dbContext.Connection.Query<int>("STUDENT_Package.StudentCount", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Student GetAllStudentById(int id)
        {
            var p = new DynamicParameters();
            p.Add("STUDENT_id", id, DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Student> result = _dbContext.Connection.Query<Student>("STUDENT_Package.GetStudentById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UpdateStudent(Student student)
        {
            var p = new DynamicParameters();
            p.Add("student_id", student.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("FLLname", student.Fullname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMG", student.Imgpath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("XHOME_LOC", student.Xhome, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("YHOME_LOC", student.Yhome, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("BUSSTATUS", student.Inbusstatus, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Bus_ROUND", student.Round, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("PARENT_id", student.Parentid, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("BUS_ID", student.Busid, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("STUDENT_Package.UpdateStudent", p, commandType: CommandType.StoredProcedure);
        }
    }
}