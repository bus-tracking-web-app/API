using First.CORE.DATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.SERVICE
{
   public interface IRoundService 
    {
        List<Roundstatus> GetAllRound();
    
        Roundstatus GetRoundByID(int id);
    }
}
