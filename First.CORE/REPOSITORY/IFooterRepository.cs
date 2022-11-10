using First.CORE.DATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.REPOSITORY
{
    public interface IFooterRepository
    {
        List<Footer> GetAllFooter();
        void CreateFooter(Footer footer);
        void UpdateFooter(Footer footer);
        void DeleteFooter(int id);
    }
}
