using First.CORE.DATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.REPOSITORY
{
    public interface IRoundRepository
    {
        List<Roundstatus> GetAllRound();
        Roundstatus GetRoundByID(int id);
    }
}
