using First.CORE.DATA;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.INFRA.SERVICE
{
    public class SchoolService : ISchoolService
    {
        private readonly ISchoolRepository _schoolRepository;
        public SchoolService(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }

        public void CREATEshcool(School school)
        {
            _schoolRepository.CREATEshcool(school);
        }

        public void deleteshcool(int id)
        {
            _schoolRepository.deleteshcool(id);
        }

        public List<School> getAllSchool()
        {
            return _schoolRepository.getAllSchool();
        }

        public void UPDATEshcool(School school)
        {
            _schoolRepository.UPDATEshcool(school);
        }
    }
}
