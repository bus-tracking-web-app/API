using Dapper;
using First.CORE.COMMON;
using First.CORE.DATA;
using First.CORE.REPOSITORY;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace First.INFRA.REPOSITORY
{
    public class ContactRepository : IContactRepository
    {
        private readonly IDbContext _dbcontext;

        public ContactRepository(IDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void CreateContact(Contactu contact)
        {
            var p = new DynamicParameters();
            p.Add("cname", contact.Fullname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("cphone", contact.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("cemail", contact.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("cmessage", contact.Massage, dbType: DbType.String, direction: ParameterDirection.Input);

            var res = _dbcontext.Connection.Execute("contact_package.createcontact", p, commandType: CommandType.StoredProcedure);




        }

        public void DeleteContact(int id)
        {

            var p = new DynamicParameters();
            p.Add("cid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var res = _dbcontext.Connection.Execute("contact_package.deletecontact", p, commandType: CommandType.StoredProcedure);
        }

        public List<Contactu> GetAllRole()
        {

            var res = _dbcontext.Connection.Query<Contactu>("contact_package.getallcontact", commandType: CommandType.StoredProcedure);
            return res.ToList();
        }

        public Contactu GetContactById(int id)
        {
            var p = new DynamicParameters();
            p.Add("cid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var res = _dbcontext.Connection.Query<Contactu>("contact_package.getcontactbyid", p, commandType: CommandType.StoredProcedure);
            return res.FirstOrDefault();

        }
    }
}
