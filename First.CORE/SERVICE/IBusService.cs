using First.CORE.DATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.SERVICE
{
    public interface IBusService
    {
        List<Bu> GetAllBus();
        Bu GetBusById(int id);
        void CreateBus(Bu bus);
        void UpdateBus(Bu bus);
        void DeleteBus(int id);
    }
}
