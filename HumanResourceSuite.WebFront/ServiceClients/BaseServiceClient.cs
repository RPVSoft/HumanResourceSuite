using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HumanResourceSuite.WebFront.ServiceClients
{
    public class BaseServiceClient
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns
        protected HttpClient PrepareHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:44372/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
    }
}