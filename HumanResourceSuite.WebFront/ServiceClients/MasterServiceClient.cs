using HumanResourceSuite.DataObjects;
using HumanResourceSuite.WebFront.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HumanResourceSuite.WebFront.ServiceClients
{
    public class MasterServiceClient : BaseServiceClient
    {

        public MasterServiceClient()
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<MasterDTO>> GetAll()
        {
            List<MasterDTO> dataToReturn = null;
            try
            {
                using (HttpClient _client = PrepareHttpClient())
                {
                    HttpResponseMessage response = await _client.GetAsync(RequestURI.MasterGetAll);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsAsync<MultiResponseDTO<MasterDTO>>();
                    }
                    else
                    {
                        var content = await response.Content.ReadAsAsync<MultiResponseDTO<MasterDTO>>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return dataToReturn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<MasterDTO>> Get()
        {
            List<MasterDTO> dataToReturn = null;
            try
            {
                using (HttpClient _client = PrepareHttpClient())
                {
                    HttpResponseMessage response = await _client.GetAsync(RequestURI.MasterGet);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsAsync<MultiResponseDTO<MasterDTO>>();
                    }
                    else
                    {
                        var content = await response.Content.ReadAsAsync<MultiResponseDTO<MasterDTO>>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataToReturn;
        }
    }
}
