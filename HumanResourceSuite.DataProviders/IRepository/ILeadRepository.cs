using HumanResourceSuite.Common.Framework;
using HumanResourceSuite.DataObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataProviders.IRepository
{
    public interface ILeadRepository
    {
        public List<LeadsDTO> GetAllLeads(AppSettings settings, out Exception ex);
        public LeadsDTO GetLeadsById(int id, AppSettings settings, out Exception ex);
        public LeadsDTO CreateLeads(LeadsDTO leadsDTO, AppSettings settings, out Exception ex);     
    }
}
