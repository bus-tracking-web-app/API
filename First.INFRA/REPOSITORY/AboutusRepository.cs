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
    public class AboutusRepository : IAboutusRepository
    {
        private readonly IDbContext _dbContext;

        public AboutusRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CREATEABOUTUS(Aboutu aboutu)
        {
            var p = new DynamicParameters();
            p.Add("pTITLE", aboutu.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pINFORMATION", aboutu.Information, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pIMAGEPATH", aboutu.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);

            _dbContext.Connection.Execute("aboutus_package.CREATEABOUTUS", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteABOUTUS(int id)
        {
            var p = new DynamicParameters();
            p.Add("pAboutid", id, DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Aboutu> result = _dbContext.Connection.Query<Aboutu>("aboutus_package.DeleteABOUTUS", p, commandType: CommandType.StoredProcedure);
        }

        public List<Aboutu> GetAllAbout()
        {
            IEnumerable<Aboutu> result = _dbContext.Connection.Query<Aboutu>("aboutus_package.GetAllAbout", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Aboutu GetAboutByID(int id)
        {
            var p = new DynamicParameters();
            p.Add("pAboutid", id, DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Aboutu> result = _dbContext.Connection.Query<Aboutu>("aboutus_package.GetAboutByID", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UPDATABOUTUS(Aboutu aboutu)
        {
            var p = new DynamicParameters();
            p.Add("pAboutid", aboutu.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("pTITLE", aboutu.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pINFORMATION", aboutu.Information, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pIMAGEPATH", aboutu.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);

            _dbContext.Connection.Execute("aboutus_package.UPDATABOUTUS", p, commandType: CommandType.StoredProcedure);

        }
    }
}
