using HumanResourceSuite.DataObjects;
using HumanResourceSuite.WebFront.Constants;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HumanResourceSuite.WebFront.ServiceClients
{
    public class CompanyServiceClient :BaseServiceClient
    {
        public CompanyServiceClient()
        {

        }
        /// <summary>
        /// Get All Company Details
        /// </summary>
        /// <returns></returns>
        public async Task<List<CompanyDTO>> GetAll()
        {
            List<CompanyDTO> dataToReturn = null;
            try
            {
                using (HttpClient _client = PrepareHttpClient())
                {
                    HttpResponseMessage response = await _client.GetAsync(RequestURI.CompanyGetAll);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<CompanyDTO>>();
                    }
                    else
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<CompanyDTO>>();
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
       /// Get Specific Company details by its ID
       /// </summary>
       /// <returns></returns>
        public async Task<List<CompanyDTO>> Get(int Id)
        {
            List<CompanyDTO> dataToReturn = null;
            try
            {
                using (HttpClient _client = PrepareHttpClient())
                {
                    HttpResponseMessage response = await _client.GetAsync(string.Format(RequestURI.CompanyGet, Id));

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<CompanyDTO>>();
                    }
                    else
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<CompanyDTO>>();
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
        /// Insert / Update Company details data
        /// </summary>
        /// <param name="companyDTO"></param>
        /// <returns></returns>

        public async Task<CompanyDTO> Insert([FromBody] CompanyDTO companyDTO)
        {
            try
            {
                using (HttpClient _client = PrepareHttpClient())
                {
                    var jsonContent = JsonConvert.SerializeObject(companyDTO);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(jsonContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage response = await _client.PostAsync(RequestURI.CompanyInsert, byteContent);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<CompanyDTO>>();
                    }
                    else
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<CompanyDTO>>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return companyDTO;
        }

    }
}
