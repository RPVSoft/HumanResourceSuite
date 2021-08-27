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
   public class CompanyProviders : BaseProvider,ICompanyProvider
    {
        private ICompanyRepository _companyRepository;
        public CompanyProviders(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        /// <summary>
        /// Get Company Details
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<CompanyDTO> GetCompanyDetails(AppSettings settings, out Exception ex)
        {
            List<CompanyDTO> companyDTOs = null;
            try
            {
                companyDTOs = _companyRepository.GetCompanyDetails(settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return companyDTOs;
        }

        /// <summary>
        /// Get Company Details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public CompanyDTO GetCompanyDetailsById(int id, AppSettings settings, out Exception ex)
        {
            CompanyDTO companyDTOs = null;
            try
            {
                companyDTOs = _companyRepository.GetCompanyDetailsById(id, settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return companyDTOs;
        }

        /// <summary>
        /// Insert Company Details
        /// </summary>
        /// <param name="companyDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public CompanyDTO InsertCompanyDetails(CompanyDTO companyDTO, AppSettings settings, out Exception ex)
        {
            try
            {
                companyDTO = _companyRepository.InsertCompanyDetails(companyDTO, settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return companyDTO;
        }

        /// <summary>
        /// Update Company Details
        /// </summary>
        /// <param name="companyDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public CompanyDTO UpdateCompanyDetails(CompanyDTO companyDTO, AppSettings settings, out Exception ex)
        {
            try
            {
                companyDTO = _companyRepository.UpdateCompanyDetails(companyDTO, settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return companyDTO;
        }

        /// <summary>
        /// Remove Company Details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public string DeleteCompanyDetails(int id, AppSettings settings, out Exception ex)
        {
            string result = null;
            try
            {
                result = _companyRepository.DeleteCompanyDetails(id, settings, out ex);
            }
            catch (Exception exception)
            {
                ex = exception;
            }
            return result;
        }
    }
}
