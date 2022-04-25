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
                    select neo).ToList();
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
#region r
/*
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
    foreach (var item4 in item)
    {


        foreach (var item1 in item4)
        {
            List<PlanetInfo.CloseApproachData> closeApproachData = new List<PlanetInfo.CloseApproachData>();
            foreach (var item2 in item1["close_approach_data"])
            {
                closeApproachData.Add(
                    new PlanetInfo.CloseApproachData()
                    {
                        close_approach_date = item2["close_approach_date"].ToString(),
                        close_approach_date_full = item2["close_approach_date_full"].ToString(),
                        epoch_date_close_approach = item2["epoch_date_close_approach"].ToString(),
                        miss_distance = new PlanetInfo.MissDistance()
                        {
                            astronomical = item2["miss_distance"]["astronomical"].ToString(),
                            kilometers = item2["miss_distance"]["kilometers"].ToString(),
                            lunar = item2["miss_distance"]["lunar"].ToString(),
                            miles = item2["miss_distance"]["miles"].ToString()
                        },
                        orbiting_body = item2["orbiting_body"].ToString(),
                        relative_velocity = new PlanetInfo.RelativeVelocity()
                        {
                            kilometers_per_hour = item2["relative_velocity"]["kilometers_per_hour"].ToString(),
                            kilometers_per_second = item2["relative_velocity"]["kilometers_per_second"].ToString(),
                            miles_per_hour = item2["relative_velocity"]["miles_per_hour"].ToString(),
                        }
                    });
            }
            date.astroids.Add(new PlanetInfo.Astroid()
            {
                links = new PlanetInfo.Links()
                {
                    //next = item1["links"]["next"].ToString()
                    //prev = item1["links"]["prev"].ToString(),
                    self = item1["links"]["self"].ToString()
                },
                id = item1["id"].ToString(),
                neo_reference_id = item1["neo_reference_id"].ToString(),
                name = item1["name"].ToString(),
                is_potentially_hazardous_asteroid = bool.Parse(item1["is_potentially_hazardous_asteroid"].ToString()),
                nasa_jpl_url = item1["nasa_jpl_url"].ToString(),
                is_sentry_object = bool.Parse(item1["is_sentry_object"].ToString()),
                estimated_diameter = new PlanetInfo.EstimatedDiameter()
                {
                    feet = new PlanetInfo.mesures()
                    {
                        estimated_diameter_min = double.Parse(item1["estimated_diameter"]["feet"]["estimated_diameter_min"].ToString()),
                        estimated_diameter_max = double.Parse(item1["estimated_diameter"]["feet"]["estimated_diameter_max"].ToString())
                    },
                    kilometers = new PlanetInfo.mesures()
                    {
                        estimated_diameter_min = double.Parse(item1["estimated_diameter"]["kilometers"]["estimated_diameter_min"].ToString()),
                        estimated_diameter_max = double.Parse(item1["estimated_diameter"]["kilometers"]["estimated_diameter_max"].ToString())
                    },
                    meters = new PlanetInfo.mesures()
                    {
                        estimated_diameter_min = double.Parse(item1["estimated_diameter"]["meters"]["estimated_diameter_min"].ToString()),
                        estimated_diameter_max = double.Parse(item1["estimated_diameter"]["meters"]["estimated_diameter_max"].ToString())
                    },
                    miles = new PlanetInfo.mesures()
                    {
                        estimated_diameter_min = double.Parse(item1["estimated_diameter"]["miles"]["estimated_diameter_min"].ToString()),
                        estimated_diameter_max = double.Parse(item1["estimated_diameter"]["miles"]["estimated_diameter_max"].ToString())
                    }
                },
                close_approach_data = closeApproachData,
                absolute_magnitude_h = double.Parse(item1["absolute_magnitude_h"].ToString())

            });
        }
    }*/
#endregion
//root.near_earth_objects.dates.Add(date);