using First.CORE.DATA;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using System.Collections.Generic;

namespace First.INFRA.SERVICE
{

    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void CreateContact(Contactu contact)
        {
            _contactRepository.CreateContact(contact);
        }

        public void DeleteContact(int id)
        {
            _contactRepository.DeleteContact(id);
        }

        public List<Contactu> GetAllRole()
        {
            return _contactRepository.GetAllRole();
        }

        public Contactu GetContactById(int id)
        {
            return _contactRepository.GetContactById(id);
        }

    }
}
