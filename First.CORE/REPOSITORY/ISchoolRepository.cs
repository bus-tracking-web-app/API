using First.CORE.DATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.REPOSITORY
{
    public interface ISchoolRepository
    {
        List<School> getAllSchool();
        void CREATEshcool(School school);
        void UPDATEshcool(School school);
        void deleteshcool(int id);

    }
}
