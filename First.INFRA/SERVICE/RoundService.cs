using First.CORE.DATA;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.INFRA.SERVICE
{
    public class RoundService : IRoundService
    {
        private readonly IRoundRepository _roundRepository;
     

        public RoundService(IRoundRepository roundRepository)
        {
            _roundRepository = roundRepository;
        }

        public List<Roundstatus> GetAllRound()
        {
            return _roundRepository.GetAllRound();
        }
     

        Roundstatus IRoundService.GetRoundByID(int id)
        {
            return _roundRepository.GetRoundByID(id);
        }
    }
}
