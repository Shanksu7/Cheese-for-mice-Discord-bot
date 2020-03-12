using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_Library.Manager
{
    public class Web
    {
        static string BaseURL = " https://cheese.formice.com/api/";
        protected static async Task<T> GetAsync<T>(string route) where T : class
        {
            var url = BaseURL + route;
            using (var httpClientHandler = new HttpClientHandler())
            {
                httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
                {
                    return true;
                };
                using (var client = new HttpClient(httpClientHandler))
                {
                    var response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<T>(responseBody);
                    return obj;
                }
            }
        }
    }
}
