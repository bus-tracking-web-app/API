using First.CORE.DATA;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.INFRA.SERVICE
{

    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _homeRepository;

        public HomeService(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }

        public void CREATEHome(Home home)
        {
            _homeRepository.CREATEHome(home);
        }

        public void DeleteHome(int id)
        {
            _homeRepository.DeleteHome(id);
        }

        public List<Home> GetAllHome()
        {
            return _homeRepository.GetAllHome();   
        }

      

        public void UPDATHome(Home home)
        {
            _homeRepository.UPDATHome(home);
        }
    }
}