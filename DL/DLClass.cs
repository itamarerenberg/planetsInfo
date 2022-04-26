using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static BE.Astroid;
using System.Threading;

namespace DL
{
    public class DLClass
    {
        string API_KEY = DLConfig.get_nasa_API_key();

        public POD GetPOD(DateTime date)
        {

            //todo: move the apikey to a gitignore file 


            var client = new RestClient("https://api.nasa.gov/planetary/apod");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("api_key", API_KEY);
            request.AddParameter("date", date.ToString("yyyy-MM-dd"));

            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<POD>(response.Content);
        }

        public Planet GetPlanet(string planetName)
        {
            return solarSystemInfo.info[planetName];
        }

        public List<string> GetSSPlanets()
        {
            return solarSystemInfo.info.Keys.ToList();
        }

        public IEnumerable<Astroid> GetNearEarthAstroid(DateTime startDate, DateTime endDate, float minDiameter = 0, float maxDiameter = float.PositiveInfinity, bool? isDangeruse = null)
        {
            var client = new RestClient("https://api.nasa.gov/neo/rest/v1/feed");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("api_key", API_KEY);
            request.AddParameter("start_date", startDate.ToString("yyyy-MM-dd"));
            //request.AddParameter("end_date", endDate.ToString("yyyy-MM-dd"));

            IRestResponse response = client.Execute(request);
            JObject rss = JObject.Parse(response.Content);


            List<Astroid> all_neObjects = new List<Astroid>();
            foreach (var time_period in rss["near_earth_objects"])
            {
                foreach (var ne_object in time_period.First)
                {
                    all_neObjects.Add(JAstroidToAstroid(ne_object));
                }
            }
            var res = (from neo in all_neObjects
                       where (isDangeruse == null || neo.is_potentially_hazardous_asteroid == isDangeruse)
                       && neo.estimated_diameter_min > minDiameter
                       && neo.estimated_diameter_max < maxDiameter
                       select neo);
            return res;
        }

        private Astroid JAstroidToAstroid(JToken jastroid)
        {
            Astroid castroid = new Astroid()
            {
                id = jastroid["id"].ToString(),
                neo_reference_id = jastroid["neo_reference_id"].ToString(),
                name = jastroid["name"].ToString(),
                nasa_jpl_url = jastroid["nasa_jpl_url"].ToString(),
                estimated_diameter_min = float.Parse(jastroid["estimated_diameter"]["kilometers"]["estimated_diameter_min"].ToString()),
                estimated_diameter_max = float.Parse(jastroid["estimated_diameter"]["kilometers"]["estimated_diameter_max"].ToString()),
                absolute_magnitude_h = float.Parse(jastroid["absolute_magnitude_h"].ToString()),
                is_potentially_hazardous_asteroid = bool.Parse(jastroid["is_potentially_hazardous_asteroid"].ToString()),
                is_sentry_object = bool.Parse(jastroid["is_sentry_object"].ToString())
            };
            return castroid;
        }

        public BE.Search.Root GetSearchResult(string search)
        {
            var client = new RestClient("https://images-api.nasa.gov/search");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddParameter("q", search);
            request.AddParameter("media_type", "image");
            IRestResponse response = client.Execute(request);
            var searchResult = JsonConvert.DeserializeObject<Search.Root>(response.Content);
            return searchResult;

        }
    }
}
