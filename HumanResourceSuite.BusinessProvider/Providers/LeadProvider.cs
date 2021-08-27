using HumanResourceSuite.BusinessProviders.IProviders;
using HumanResourceSuite.Common.Framework;
using HumanResourceSuite.DataObjects;
using HumanResourceSuite.DataProviders.Configurations;
using HumanResourceSuite.DataProviders.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.BusinessProviders.Providers
{
   public class LeadProvider : BaseProvider,ILeadsProvider
    {

        private ILeadRepository _leadRepository;
           
            public LeadProvider(ILeadRepository leadRepository)
        {
            _leadRepository = leadRepository;
        }
        /// <summary>
        /// Gel All Leads
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<LeadsDTO> GetAllLeads(AppSettings settings, out Exception ex)
        {
            List<LeadsDTO> leadsDTOs = null;
            try
            {
                leadsDTOs = _leadRepository.GetAllLeads(settings,out ex);
            }
            catch(Exception exception)
            {
                ex = exception;
            }
            return leadsDTOs;
        }

        /// <summary>
        /// Get Leads by Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public LeadsDTO GetLeadsById(int id, AppSettings settings, out Exception ex)
        {
            LeadsDTO leadsDTOs = null;
            try
            {
                leadsDTOs = _leadRepository.GetLeadsById(id, settings, out ex);
            }
            catch(Exception exception)
            {
                ex = exception;
            }
            return leadsDTOs;
        }

        /// <summary>
        /// Create Leads
        /// </summary>
        /// <param name="leadsDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public LeadsDTO CreateLeads(LeadsDTO leadsDTO, AppSettings settings, out Exception ex)
        {            
            try
            {
                leadsDTO = _leadRepository.CreateLeads(leadsDTO, settings, out ex);
            }
            catch(Exception exception)
            {
                ex = exception;
            }
            return leadsDTO;
        }     

    }
}
