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
    public class BusRepository: IBusRepository
    {
        private readonly IDbContext _dbContext;

        public BusRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateBus(Bu bus)
        {
            var p = new DynamicParameters();
            p.Add("BusN", bus.Busnumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("BusD", bus.Busdriver, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("BusR", bus.Round, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("BusT", bus.Teacher, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Bus_package.CreateBus", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteBus(int id)
        {
            var p = new DynamicParameters();
            p.Add("BId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Bus_package.DeleteBus", p, commandType: CommandType.StoredProcedure);
        }

        public List<Bu> GetAllBus()
        {
            IEnumerable<Bu> result = _dbContext.Connection.Query<Bu>("Bus_package.GetAllBus", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Bu GetBusById(int id)
        {
            var p = new DynamicParameters();
            p.Add("BId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Bu> result = _dbContext.Connection.Query<Bu>("Bus_package.GetBusById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public List<Bu> searchByBusNumber(int bnum)
        {
            var p = new DynamicParameters();
            p.Add("bnum", bnum, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Bu> result = _dbContext.Connection.Query<Bu>("Bus_package.searchBusNumber", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public void UpdateBus(Bu bus)
        {
            var p = new DynamicParameters();
            p.Add("BId", bus.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("BusN", bus.Busnumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("BusD", bus.Busdriver, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("BusR", bus.Round, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("BusT", bus.Teacher, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Bus_package. UpdateBus", p, commandType: CommandType.StoredProcedure);


        }
    }
}
