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
        string API_KEY = DLConfig.NASA_API_KEY;

        public BE.POD GetPOD(DateTime ?date = null)
        {
            DateTime dt = (DateTime)(date != null? date : DateTime.Now);

            //todo: move the apikey to a gitignore file 
            

            var client = new RestClient("https://api.nasa.gov/planetary/apod");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("api_key", API_KEY);
            request.AddParameter("date", dt.ToString("yyyy-MM-dd"));

            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<POD>(response.Content);
        }

        public List<BE.PlanetInfo> Get8Planets()
        {
            return null;
        }

        public List<BE.PlanetInfo> GetNearEarthAstroid(DateTime startDate, DateTime endDate,float minDiameter=-1,bool ?isDangerous=null)
        {
            var client = new RestClient("https://api.nasa.gov/neo/rest/v1/feed");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("api_key", API_KEY);
            request.AddParameter("start_date", startDate);
            request.AddParameter("end_date", endDate);
            if (minDiameter != -1)
            {
                request.AddParameter("end_date", minDiameter);
            }
        }
    }
}
