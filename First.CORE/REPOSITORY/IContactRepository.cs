using First.CORE.DATA;
using System.Collections.Generic;

namespace First.CORE.REPOSITORY
{
    public interface IContactRepository
    {

        List<Contactu> GetAllRole();
        void CreateContact(Contactu contact);
        void DeleteContact(int id);
        Contactu GetContactById(int id);


    }
}
