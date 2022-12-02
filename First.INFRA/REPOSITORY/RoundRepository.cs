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
   public class RoundRepository : IRoundRepository
    {

        private readonly IDbContext _dbContext;

        public RoundRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
     

       

        public List<Roundstatus> GetAllRound()
        {
            IEnumerable<Roundstatus> result = _dbContext.Connection.Query<Roundstatus>("ROUNDSTATUS_package.GetAllround", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Roundstatus GetRoundByID(int id)
        {
            var p = new DynamicParameters();
            p.Add("pRoundid", id, DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Roundstatus> result = _dbContext.Connection.Query<Roundstatus>("ROUNDSTATUS_package.GetroundByID", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
