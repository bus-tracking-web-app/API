using First.CORE.DATA;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.INFRA.SERVICE
{
    public class AboutusService : IAboutusService
    {
        private readonly IAboutusRepository _aboutuRepository;
        public AboutusService(IAboutusRepository aboutuRepository)
        {
            _aboutuRepository = aboutuRepository;
        }

        public void CREATEABOUTUS(Aboutu aboutu)
        {
            _aboutuRepository.CREATEABOUTUS(aboutu);
        }

        public void DeleteABOUTUS(int id)
        {
            _aboutuRepository.DeleteABOUTUS(id);
        }

        public Aboutu GetAboutByID(int id)
        {
           return _aboutuRepository.GetAboutByID(id);
        }

        public List<Aboutu> GetAllAbout()
        {
            return _aboutuRepository.GetAllAbout();
        }

        public void UPDATABOUTUS(Aboutu aboutu)
        {
            _aboutuRepository.UPDATABOUTUS(aboutu);
        }
    }
}
