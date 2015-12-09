using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class FootballDataRequest
    {
        HttpRequestMessage _msg;
        string type;
        private const string _baseUrl = "http://api.football-data.org/v1";
        private string _parameters;
        private const string _token = "037956c585d4459a8b65c7ac60aebfef";
    }
}
