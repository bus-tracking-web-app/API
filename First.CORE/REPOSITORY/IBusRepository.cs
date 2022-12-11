using First.CORE.DATA;
using First.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.REPOSITORY
{
    public interface IBusRepository
    {
        List<AllBus> GetAllBus();
        List<Bu> GetAll();
        Bu GetBusById(int id);
        void CreateBus(Bu bus);
        void UpdateBus(Bu bus);
        void DeleteBus(int id);
        List<AllBus> searchByBusNumber(int bnum);
        List<BusAndStudentCountcs> GetBusAndStudentCount();
    }
}
