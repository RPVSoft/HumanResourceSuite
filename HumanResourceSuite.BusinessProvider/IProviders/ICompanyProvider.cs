using HumanResourceSuite.Common.Framework;
using HumanResourceSuite.DataObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.BusinessProviders.IProviders
{
   public interface ICompanyProvider
    {
        public List<CompanyDTO> GetCompanyDetails(AppSettings settings, out Exception ex);
        public CompanyDTO GetCompanyDetailsById(int id, AppSettings settings, out Exception ex);
        public CompanyDTO InsertCompanyDetails(CompanyDTO companyDTO, AppSettings settings, out Exception ex);
        public CompanyDTO UpdateCompanyDetails(CompanyDTO companyDTO, AppSettings settings, out Exception ex);
        public string DeleteCompanyDetails(int id, AppSettings settings, out Exception ex);
    }
}
