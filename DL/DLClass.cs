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
        string API_KEY = DLConfig.get_nasa_API_key();

        public POD GetPOD(DateTime date)
        {
            DateTime dt = date != null? date : DateTime.Now;

            //todo: move the apikey to a gitignore file 
            

            var client = new RestClient("https://api.nasa.gov/planetary/apod");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("api_key", API_KEY);
            request.AddParameter("date", dt.ToString("yyyy-MM-dd"));

            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<POD>(response.Content);
        }

        public Planet GetPlanet(string planetName)
        {
            return solarSystemInfo.info[planetName];
        }

        public LinkedList<dynamic> GetNearEarthAstroid(DateTime startDate, DateTime endDate)
        {
            var client = new RestClient("https://api.nasa.gov/neo/rest/v1/feed");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("api_key", API_KEY);
            request.AddParameter("start_date", startDate.ToString("yyyy-MM-dd"));
            //request.AddParameter("end_date", endDate.ToString("yyyy-MM-dd"));

            IRestResponse response = client.Execute(request);

            //var a = JsonConvert.DeserializeObject(response.Content);
            var a = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Console.WriteLine(response.ToString());
            return null;
        }

        public BE.Planet GetSearchResult(string search)
        {
            var client = new RestClient("https://images-api.nasa.gov/search");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddParameter("q", search);
            request.AddParameter("media_type", "image");
            IRestResponse response = client.Execute(request);
            var a = JsonConvert.DeserializeObject<Planet>(response.Content);
            Console.WriteLine(a.ToString());
            return a;

        }
    }
}
