using HumanResourceSuite.Common.Framework;
using HumanResourceSuite.DataObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataProviders.IRepository
{
   public interface ICompanyRepository
    {
        public List<CompanyDTO> GetCompanyDetails(AppSettings settings, out Exception ex);
        public CompanyDTO GetCompanyDetailsById(int id, AppSettings settings, out Exception ex);
        public CompanyDTO InsertCompanyDetails(CompanyDTO companyDTO, AppSettings settings, out Exception ex);
        public CompanyDTO UpdateCompanyDetails(CompanyDTO companyDTO, AppSettings settings, out Exception ex);
        public string DeleteCompanyDetails(int id, AppSettings settings, out Exception ex);
    }
}
