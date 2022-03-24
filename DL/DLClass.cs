using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Newtonsoft.Json;

namespace DL
{
    public class DLClass
    {
        public BE.POD getPod(DateTime ?dt = null)
        {
            dt = dt != null? dt : DateTime.Now; 
            //todo: move the apikey to a gitignore file 
            string apiKey = "P8NQXJLV9cTtfJBeIxONVhKCasipTQ0JJsD0wi1f";

            var client = new RestClient("https://api.nasa.gov/planetary/apod");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("api_key", apiKey);
            request.AddParameter("date", dt.ToString("yyyy-MM-dd"));

            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<POD>(response.Content);
        }
    }
}
