using First.CORE.DATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.REPOSITORY
{
    public interface IHomeRepository
    {
        List<Home> GetAllHome();
    
        void CREATEHome(Home home);
        void UPDATHome(Home home);
        void DeleteHome(int id);
    }
}
