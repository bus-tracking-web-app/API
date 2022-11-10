using First.CORE.COMMON;
using First.CORE.DATA;
using First.CORE.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using System.Linq;

namespace First.INFRA.REPOSITORY
{
    public class FooterRepository:IFooterRepository
    {
        private readonly IDbContext _dbContext;

        public FooterRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateFooter(Footer footer)
        {
            var p = new DynamicParameters();
            p.Add("aboutTxt", footer.Abouttxt, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("address", footer.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phone", footer.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("email", footer.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Footer_Package.CreateFooter", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteFooter(int id)
        {
            var p = new DynamicParameters();
            p.Add("FId", id, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Footer_Package.DeleteFooter", p, commandType: CommandType.StoredProcedure);
        }

        public List<Footer> GetAllFooter()
        {
            IEnumerable<Footer> result = _dbContext.Connection.Query<Footer>("Footer_Package.GetAllFooter", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public void UpdateFooter(Footer footer)
        {
            var p = new DynamicParameters();
            p.Add("FId", footer.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("FaboutTxt", footer.Abouttxt, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Faddress", footer.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phone", footer.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Femail", footer.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Footer_Package.UpdateFooter", p, commandType: CommandType.StoredProcedure);
        }
    }
}
