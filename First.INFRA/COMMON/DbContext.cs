using First.CORE.COMMON;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Data.Common;

namespace First.INFRA.COMMON
{

    public class DbContext : IDbContext
    {

        private DbConnection _connection;
        private readonly IConfiguration _confugure;


        public DbContext(IConfiguration confugure)
        {
            _confugure = confugure;
        }

        public DbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new OracleConnection(_confugure["ConnectionStrings:DBConnectionString"]);
                    _connection.Open();

                }

                else if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }




    }
}
