
using HumanResourceSuite.BusinessProviders.IProviders;
using HumanResourceSuite.Common.Framework;
using HumanResourceSuite.DataObjects;
using HumanResourceSuite.DataProviders.Configurations;
using HumanResourceSuite.DataProviders.IRepository;
using HumanResourceSuite.DataProviders.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.BusinessProviders.Providers
{
    public class MasterProvider : BaseProvider,IMasterProvider 
    {

        private IMasterRepository _masterRepository;
        public MasterProvider(IMasterRepository masterProvider)
        {
            _masterRepository = masterProvider;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<MasterDTO> Get(int id, AppSettings settings, out Exception exception)
        {
            List<MasterDTO> dataToReturn = null; exception = null;
            try
            {
                dataToReturn = _masterRepository.Get(id, settings, out exception);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            return dataToReturn;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<MasterDTO> GetAll(AppSettings settings, out Exception exception)
        {
            List<MasterDTO> dataToReturn = null;
            try
            {
                dataToReturn = _masterRepository.GetAll(settings, out exception);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            return dataToReturn;
        }      


    }
}
