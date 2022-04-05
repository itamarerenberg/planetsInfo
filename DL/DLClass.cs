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

        public BE.POD GetPOD(DateTime date)
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

        public List<BE.Planet> Get8Planets()
        {
            var link = "https://firebasestorage.googleapis.com/v0/b/planets-9419d.appspot.com/o/";
            List<BE.Planet> planets = new List<BE.Planet>();
            planets.Add(new Planet()
            {
                Name = "Venus",
                GeneralInfo = "Venus is the second planet far from the Sun. Venus' orbit is the closest to Earth's orbit, and its size is close to Earth's size. The most striking feature of Venus is the immense heat that prevails on its surface, more than any other planet in the solar system.",
                Category = "Terrestrial planet",
                Location = "Inner Solar System",
                AvgDistanceFromSun = "108,208,926",
                OrbitalPeriod = "224.7",
                AvgOrbitalSpeed = "35.02",
                Inclination = "3.39471",
                Satellites = "0",
                Radius = "6,052",
                SurfaceArea = "4.6×10^8",
                Mass = "4.8685×10^24",
                Density = "5.204",
                RotationPeriod = "117",
                RotationSpeed = "0.0018",
                AxialTilt = "2.64",
                AvgSurfaceTemp = "436.8",
                ImageUrl = $"{link}Venus.png?alt=media&token=b4a391bc-9574-4fec-b62e-ca9e0872134c"
            });
            //Mercury
            planets.Add(new Planet()
            {
                Name = "Mercury",
                GeneralInfo = "Mercury is the closest planet to the Sun. In terms of mass, it is the eighth and smallest planet in the solar system. It is much smaller than Earth, and similar in size to the Moon. Gravity on its surface is 2.5 times smaller than on Earth. The sunrise is visible on its surface once every two years - a unique phenomenon in the solar system.",
                Category = "Terrestrial planet",
                Location = "Inner Solar System",
                AvgDistanceFromSun = "57,909,176",
                OrbitalPeriod = "87.96",
                AvgOrbitalSpeed = "47.36",
                Inclination = "7.00487",
                Satellites = "0",
                Radius = "2,439",
                SurfaceArea = "7.5×10^7",
                Mass = "3.302×10^23",
                Density = "5.427",
                RotationPeriod = "58.64",
                RotationSpeed = "0.0030",
                AxialTilt = "0.01",
                AvgSurfaceTemp = "166.85",
                ImageUrl = $"{link}Mercury.png?alt=media&token=c50ac6bc-a18b-4a5e-a7d2-785a077aa5fd"
            });
            //Earth
            planets.Add(new Planet()
            {
                Name = "Earth",
                GeneralInfo = "Earth is the third planet in the solar system and the fifth largest in the system, and the largest of the four terrestrial planets. Earth is the only known celestial body that contains life forms.",
                Category = "Terrestrial planet",
                Location = "Inner Solar System",
                AvgDistanceFromSun = "149,598,0236",
                OrbitalPeriod = "365.25",
                AvgOrbitalSpeed = "29.783",
                Inclination = "0",
                Satellites = "1",
                Radius = "6,378",
                SurfaceArea = "510,065,600",
                Mass = "5.9742×10^24",
                Density = "5.5153",
                RotationPeriod = "23.93",
                RotationSpeed = "0.4651",
                AxialTilt = "23.436",
                AvgSurfaceTemp = "14",
                ImageUrl = $"{link}Earth.png?alt=media&token=9ba75992-dddc-4ccb-b520-09e6b467a87d"
            });
            //Mars
            planets.Add(new Planet()
            {
                Name = "Mars",
                GeneralInfo = "Mars is the fourth planet in the solar system. Its orbit is the second closest to Earth's orbit (after Venus) and is the second smallest planet, larger only than a hot star. The color of Mars' face is reddish due to the abundance of iron oxides in its soil. On Mars is the highest mountain in the solar system, the volcano Olympus Mons - 27 km high.",
                Category = "Terrestrial planet",
                Location = "Inner Solar System",
                AvgDistanceFromSun = "227,936,637",
                OrbitalPeriod = "686.971",
                AvgOrbitalSpeed = "24.077",
                Inclination = "1.85061",
                Satellites = "2",
                Radius = "3,396.2",
                SurfaceArea = "1.448×10^8",
                Mass = "6.4191×10^23",
                Density = "3.94",
                RotationPeriod = "24.622",
                RotationSpeed = "0.241",
                AxialTilt = "25.19",
                AvgSurfaceTemp = "-63.15",
                ImageUrl = $"{link}Mars.png?alt=media&token=f6f03b58-422e-4020-803c-09f90b025a56"
            });
            //Neptune
            planets.Add(new Planet()
            {
                Name = "Neptune",
                GeneralInfo = "Neptune is the eighth planet in the solar system. It is the smallest of the four gas giants and is classified in the Ice Giant subcategory because it is covered with a layer of water and ice. Neptune, is in orbital resonance with the dwarf planet Pluto.",
                Category = "Gas giant",
                Location = "Outer Solar System",
                AvgDistanceFromSun = "4,498,252,900",
                OrbitalPeriod = "60,190",
                AvgOrbitalSpeed = "5.432",
                Inclination = "1.76917",
                Satellites = "14",
                Radius = "24,786",
                SurfaceArea = "‎7.65×10^9",
                Mass = "1.024×10^26‎",
                Density = "1.64",
                RotationPeriod = "0.67",
                RotationSpeed = "2.68",
                AxialTilt = "29.58",
                AvgSurfaceTemp = "-212",
                ImageUrl = $"{link}Neptune.png?alt=media&token=ab6b1acf-b745-4e0c-a94c-602261c230d3"
            });
            //Jupiter
            planets.Add(new Planet()
            {
                Name = "Jupiter",
                GeneralInfo = "Jupiter is a gas giant and planet with the largest mass in the solar system, the fifth farthest from the sun and the first in the gaseous planet category. Jupiter is made mainly of gas: about 90% of its mass is hydrogen and about 10% is helium.",
                Category = "Gas giant",
                Location = "Outer Solar System",
                AvgDistanceFromSun = "778,340,821",
                OrbitalPeriod = "4,332.58",
                AvgOrbitalSpeed = "13.0697",
                Inclination = "1.30530",
                Satellites = "79",
                Radius = "71,492",
                SurfaceArea = "6.41×10^10",
                Mass = "1.899×10^27",
                Density = "1.326",
                RotationPeriod = "0.41",
                RotationSpeed = "12.6",
                AxialTilt = "3.12",
                AvgSurfaceTemp = "-121",
                ImageUrl = $"{link}Jupiter.png?alt=media&token=89cef847-a02e-40df-87c0-9401dd74775c"
            });
            //Saturn
            planets.Add(new Planet()
            {
                Name = "Saturn",
                GeneralInfo = "Saturn is the sixth planet farthest from the Sun and the second in a series of gaseous planets. Saturn is surrounded by planetary rings called Saturn's rings, which contain mostly ice and dust. Because Saturn was the seventh planet in ancient times, the seventh day of the week was named Saturday.",
                Category = "Gas giant",
                Location = "Outer Solar System",
                AvgDistanceFromSun = "1,426,725,413",
                OrbitalPeriod = "10,832.327",
                AvgOrbitalSpeed = "9.639",
                Inclination = "2.488",
                Satellites = "82",
                Radius = "60,268",
                SurfaceArea = "4.27×10^10",
                Mass = "5.8646×10^26",
                Density = "0.687",
                RotationPeriod = "0.44",
                RotationSpeed = "9.87",
                AxialTilt = "26.73",
                AvgSurfaceTemp = "-130",
                ImageUrl = $"{link}Saturn.png?alt=media&token=d3d45d23-7a14-410e-9373-1a752c4977eb"
            });
            //Uranus
            planets.Add(new Planet()
            {
                Name = "Uranus",
                GeneralInfo = "Uranus is the seventh planet far from the Sun. Uranus is one of the four gas giants and is classified in the ice giant sub-category. It is composed mainly of hydrogen and helium and in its center is a molten core of iron and silicates surrounded by a thick layer of ice, methane and ammonia. Beyond the solid layers lies the thick atmosphere composed of hydrogen and helium.",
                Category = "Gas giant",
                Location = "Outer Solar System",
                AvgDistanceFromSun = "2,870,972,220",
                OrbitalPeriod = "30,799.095",
                AvgOrbitalSpeed = "6.795",
                Inclination = "0.76986",
                Satellites = "27",
                Radius = "25,559",
                SurfaceArea = "8.13×10^9",
                Mass = "8.686×10^25",
                Density = "1.29",
                RotationPeriod = "0.72",
                RotationSpeed = "2.59",
                AxialTilt = "97.86",
                AvgSurfaceTemp = "-220",
                ImageUrl = $"{link}Uranus.png?alt=media&token=cfef9709-89f4-4185-8cb6-8d16faefdc2d"
            });
            return planets;
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
            return a;
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
