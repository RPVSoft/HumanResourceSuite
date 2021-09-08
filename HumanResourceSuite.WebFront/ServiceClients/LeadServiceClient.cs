using HumanResourceSuite.DataObjects;
using HumanResourceSuite.WebFront.Constants;
using HumanResourceSuite.WebFront.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceSuite.WebFront.ServiceClients
{
    public class LeadServiceClient :BaseServiceClient
    {
        public LeadServiceClient()
        {

        }
        /// <summary>
        /// Get All Leads
        /// </summary>
        /// <returns></returns>
        public async Task<List<LeadsModel>> GetAll()
        {
            List<LeadsModel> dataToReturn = null;
            try
            {
                using (HttpClient _client = PrepareHttpClient())
                {
                    HttpResponseMessage response = await _client.GetAsync(RequestURI.LeadsGetAll);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<LeadsModel>>();
                    }
                    else
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<LeadsModel>>();
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
        /// Get specific Lead by its ID
        /// </summary>
        /// <returns></returns>
        public async Task<List<LeadsModel>> Get(int Id)
        {
            List<LeadsModel> dataToReturn = null;
            try
            {
                using (HttpClient _client = PrepareHttpClient())
                {
                    HttpResponseMessage response = await _client.GetAsync(string.Format(RequestURI.LeadsGet,  Id));
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<LeadsModel>>();
                    }
                    else
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<LeadsModel>>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataToReturn;
        }

        public async Task<LeadsModel> Insert([FromBody] LeadsModel leadsModel)
        {
           // LeadDTO dataToReturn = null;
            try
            {
                using (HttpClient _client = PrepareHttpClient())
                {
                    var jsonContent = JsonConvert.SerializeObject(leadsModel);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(jsonContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


                    HttpResponseMessage response = await _client.PostAsync(RequestURI.LeadsInsert, byteContent);

                   if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<LeadsModel>>();
                    }
                    else
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<LeadsModel>>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return leadsModel;
        }

    }
}
