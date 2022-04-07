using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Astroid
    {
        //public Links links { get; set; }
        public string id { get; set; }
        public string neo_reference_id { get; set; }
        public string name { get; set; }
        public string nasa_jpl_url { get; set; }
        public double absolute_magnitude_h { get; set; }
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
        public bool is_potentially_hazardous_asteroid { get; set; }
        //public List<CloseApproachData> close_approach_data { get; set; }
        public bool is_sentry_object { get; set; }

        public override string ToString()
        {
            return "id: " + id + " | name: " + name + " | min d: " + estimated_diameter_min + " | max d: " + estimated_diameter_max + " | dengerous: " + is_potentially_hazardous_asteroid;
        }

    }
    //public class PlanetInfo
    //{

    //// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    //    public class Links
    //    {
    //        public string next { get; set; }
    //        public string prev { get; set; }
    //        public string self { get; set; }
    //    }

    //    public class mesures
    //    {
    //        public double estimated_diameter_min { get; set; }
    //        public double estimated_diameter_max { get; set; }
    //    }


    //    public class EstimatedDiameter
    //    {
    //        public mesures kilometers { get; set; }
    //        public mesures meters { get; set; }
    //        public mesures miles { get; set; }
    //        public mesures feet { get; set; }
    //    }

    //    public class RelativeVelocity
    //    {
    //        public string kilometers_per_second { get; set; }
    //        public string kilometers_per_hour { get; set; }
    //        public string miles_per_hour { get; set; }
    //    }

    //    public class MissDistance
    //    {
    //        public string astronomical { get; set; }
    //        public string lunar { get; set; }
    //        public string kilometers { get; set; }
    //        public string miles { get; set; }
    //    }

    //    public class CloseApproachData
    //    {
    //        public string close_approach_date { get; set; }
    //        public string close_approach_date_full { get; set; }
    //        public object epoch_date_close_approach { get; set; }
    //        public RelativeVelocity relative_velocity { get; set; }
    //        public MissDistance miss_distance { get; set; }
    //        public string orbiting_body { get; set; }
    //    }




    //    public class Date
    //    {
    //        public List<Astroid> astroids { get; set; }
    //    }

    //    public class NearEarthObject
    //    {
    //        public List<Date> dates { get; set; }
    //    }


    //    public class Root
    //    {
    //        public Links links { get; set; }
    //        public int element_count { get; set; }
    //        public NearEarthObject near_earth_objects { get; set; }
    //    }

    //}
}
