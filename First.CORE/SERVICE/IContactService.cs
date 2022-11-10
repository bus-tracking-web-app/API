using First.CORE.DATA;
using System.Collections.Generic;

namespace First.CORE.SERVICE
{
    public interface IContactService
    {
        List<Contactu> GetAllRole();
        void CreateContact(Contactu contact);
        void DeleteContact(int id);
        Contactu GetContactById(int id);

    }
}
