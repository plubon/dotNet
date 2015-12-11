using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FootballDataAPI
{
    public class ApiRequest
    {
        private HttpRequestMessage _request;
        private string _uri;
        private HttpClient _client;
        private const string _token = "037956c585d4459a8b65c7ac60aebfef";


        public ApiRequest(string uri)
        {
            _client = new HttpClient();
            _uri = uri;
            _request = new HttpRequestMessage(HttpMethod.Get, uri);
            _request.Headers.Add("X-Auth-Token", _token);
            _request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
        }

        /*public List<T> GetResultArray<T>()
        {
            var response = _client.SendAsync(_request).Result;
            var stringResponse = response.Content.ReadAsStringAsync().Result;
            List<T> unparsedData = JsonConvert.DeserializeObject<List<T>>(stringResponse);
            return unparsedData;
        }*/

        public T GetResult<T>()
        {
            var response = _client.SendAsync(_request).Result;
            var stringResponse = response.Content.ReadAsStringAsync().Result;
            T unparsedData = JsonConvert.DeserializeObject<T>(stringResponse);
            return unparsedData;
        }
    }
}
