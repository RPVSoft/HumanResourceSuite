using HumanResourceSuite.Common.Framework;
using HumanResourceSuite.DataObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.BusinessProviders.IProviders
{
   public interface ILeadsProvider
    {
        public List<LeadsDTO> GetAllLeads(AppSettings settings, out Exception ex);
        public LeadsDTO GetLeadsById(int id, AppSettings settings, out Exception ex);
        public LeadsDTO CreateLeads(LeadsDTO leadsDTO, AppSettings settings, out Exception ex);     
    }
}
