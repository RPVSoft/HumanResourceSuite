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
    public class EmployeeServiceClient :BaseServiceClient
    {
        public EmployeeServiceClient()
        {

        }
       /// <summary>
       /// Get all Employee details
       /// </summary>
       /// <returns></returns>
        public async Task<List<EmployeeDTO>> GetAll()
        {
            List<EmployeeDTO> dataToReturn = null;
            try
            {
                using (HttpClient _client = PrepareHttpClient())
                {
                    HttpResponseMessage response = await _client.GetAsync(RequestURI.EmployeeGetAll);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<EmployeeDTO>>();
                    }
                    else
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<EmployeeDTO>>();
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
      /// Get specific Employee details by its ID
      /// </summary>
      /// <returns></returns>
        public async Task<List<EmployeeDTO>> Get(int Id)
        {
            List<EmployeeDTO> dataToReturn = null;
            try
            {
                using (HttpClient _client = PrepareHttpClient())
                {
                    HttpResponseMessage response = await _client.GetAsync(string.Format(RequestURI.EmployeeGet, Id));
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<EmployeeDTO>>();
                    }
                    else
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<EmployeeDTO>>();
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
        /// Insert / Update Employee details
        /// </summary>
        /// <param name="employeeDTO"></param>
        /// <returns></returns>
        public async Task<EmployeeDTO> Insert([FromBody] EmployeeDTO employeeDTO)
        {
            try
            {
                using (HttpClient _client = PrepareHttpClient())
                {
                    var jsonContent = JsonConvert.SerializeObject(employeeDTO);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(jsonContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage response = await _client.PostAsync(RequestURI.EmployeeInsert, byteContent);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<EmployeeDTO>>();
                    }
                    else
                    {
                        var content = await response.Content.ReadAsAsync<ResponseDTO<EmployeeDTO>>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return employeeDTO;
        }

    }
}
