using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetsInfo
{
    class AstroidModel
    {
        public BE.Astroid Astroid = new BE.Astroid();
        public BL.BLClass BLClass = new BL.BLClass();

        public string id { get; set; }
        public string neo_reference_id { get; set; }
        public string name { get; set; }
        public string nasa_jpl_url { get; set; }
        public double absolute_magnitude_h { get; set; }
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
        public bool is_potentially_hazardous_asteroid { get; set; }
        public bool is_sentry_object { get; set; }

        public AstroidModel()
        {
            Astroid = BLClass.qurey(new DateTime(1999, 12, 1), new DateTime(1999, 12, 1)).First();
            id = Astroid.id;
            neo_reference_id = Astroid.neo_reference_id;
            name = Astroid.name;
            nasa_jpl_url = Astroid.nasa_jpl_url;
            absolute_magnitude_h = Astroid.absolute_magnitude_h;
            estimated_diameter_min = Astroid.estimated_diameter_min;
            estimated_diameter_max = Astroid.estimated_diameter_max;
            is_potentially_hazardous_asteroid = Astroid.is_potentially_hazardous_asteroid;
            is_sentry_object = Astroid.is_sentry_object;
        }
    }
}
