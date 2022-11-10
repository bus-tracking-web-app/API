using System.Data.Common;

namespace First.CORE.COMMON
{
    public interface IDbContext
    {
        public DbConnection Connection { get; }
    }
}
