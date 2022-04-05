using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        public BE.PlanetInfo.Root GetNearEarthAstroid(DateTime startDate, DateTime endDate)
        {
            var client = new RestClient("https://api.nasa.gov/neo/rest/v1/feed");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("api_key", API_KEY);
            request.AddParameter("start_date", startDate.ToString("yyyy-MM-dd"));
            //request.AddParameter("end_date", endDate.ToString("yyyy-MM-dd"));

            IRestResponse response = client.Execute(request);
            JObject rss = JObject.Parse(response.Content);
            PlanetInfo.Root root = new PlanetInfo.Root();
            root.links = new PlanetInfo.Links()
            {
                next = rss["links"]["next"].ToString(),
                prev = rss["links"]["prev"].ToString(),
                self = rss["links"]["self"].ToString()
            };
            root.element_count = int.Parse(rss["element_count"].ToString());
            root.near_earth_objects = new PlanetInfo.NearEarthObject();
            int i = 0;
            PlanetInfo.Date date = new PlanetInfo.Date();
            root.near_earth_objects.dates = new List<PlanetInfo.Date>();
            foreach (var item in rss["near_earth_objects"])
            {
                PlanetInfo.Astroid astroids = new PlanetInfo.Astroid();
                date.astroids = new List<PlanetInfo.Astroid>();
                //root.near_earth_objects.dates[i].astroids = new List<PlanetInfo.Astroid>();
                foreach (var item1 in item)
                {
                   date.astroids.Add(new PlanetInfo.Astroid(){
                         links = new PlanetInfo.Links()
                         {
                             //next = item1["links"]["next"].ToString()
                             //prev = item1["links"]["prev"].ToString(),
                             self = item1[0]["links"]["self"].ToString()
                         },
                         id = item1[0]["id"].ToString(),
                        neo_reference_id = item1[0]["neo_reference_id"].ToString(),
                        name = item1[0]["name"].ToString(),
                        name_limited = item1[0]["name_limited"].ToString()
                      // designation = item1[0]["designation"].ToString(),
                       //nasa_jpl_url = item1[0]["nasa_jpl_url"].ToString(),
                       //absolute_magnitude_h =double.Parse( item1[0]["absolute_magnitude_h"].ToString())

                   });
                }
                root.near_earth_objects.dates.Add(date);


            }
            var a= JsonConvert.DeserializeObject<PlanetInfo.Root>(response.Content);
            Console.WriteLine(response.ToString());
            return null;
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
