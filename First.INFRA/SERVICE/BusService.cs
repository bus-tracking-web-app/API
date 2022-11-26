using First.CORE.DATA;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.INFRA.SERVICE
{
    public class BusService:IBusService
    {
        private readonly IBusRepository _busRepository;
        public BusService(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }

        public void CreateBus(Bu bus)
        {
            _busRepository.CreateBus(bus);
        }

        public void DeleteBus(int id)
        {
            _busRepository.DeleteBus(id);
        }

        public List<Bu> GetAllBus()
        {
            return _busRepository.GetAllBus();
        }

        public Bu GetBusById(int id)
        {
           return _busRepository.GetBusById(id);
        }

        public List<Bu> searchByBusNumber(int bnum)
        {
            return _busRepository.searchByBusNumber(bnum);
        }

        public void UpdateBus(Bu bus)
        {
            _busRepository.UpdateBus(bus);
        }
    }
}
