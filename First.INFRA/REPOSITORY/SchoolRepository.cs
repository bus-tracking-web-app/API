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
    public class SchoolRepository : ISchoolRepository
    {
        private readonly IDbContext _dbContext;
        public SchoolRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CREATEshcool(School school)
        {
            var p = new DynamicParameters();
            p.Add("Plogo", school.Logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Pxschool", school.Xschool, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Pyschool", school.Yschool, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("school_package.CREATEshcool", p, commandType: CommandType.StoredProcedure);

        }

        public void deleteshcool(int id)
        {
            var p = new DynamicParameters();
            p.Add("pschoolid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("school_package.deleteshcool", p, commandType: CommandType.StoredProcedure);

        }

        public List<School> getAllSchool()
        {
            IEnumerable<School> result = _dbContext.Connection.Query<School>("school_package.getAllSchool", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public School getschoolbyID(int id)
        {
            var p = new DynamicParameters();
            p.Add("pschoolid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<School> result = _dbContext.Connection.Query<School>("school_package.getschoolbyID", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UPDATEshcool(School school)
        {
            var p = new DynamicParameters();
            p.Add("pschoolid", school.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Plogo", school.Logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Pxschool", school.Xschool, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Pyschool", school.Yschool, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("school_package.UPDATEshcool", p, commandType: CommandType.StoredProcedure);

        }
    }
}
