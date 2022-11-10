using First.CORE.DATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.SERVICE
{
    public interface IAboutusService
    {

        List<Aboutu> GetAllAbout();
        Aboutu GetAboutByID(int id);
        void CREATEABOUTUS(Aboutu aboutu);
        void UPDATABOUTUS(Aboutu aboutu);
        void DeleteABOUTUS(int id);

    }
}
