using BE;
using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    /// <summary>
    /// logical operations
    /// </summary>
    public class BLClass
    {
        static BLClass instance;
        public static BLClass Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLClass();
                return instance;
            }
        }
        DLClass dlc;
        private BLClass()
        {
            dlc = new DLClass();
        }
        //picture of the day by immaga
        public BE.POD GetPOD(DateTime? date = null)
        {
            DateTime dt = (DateTime)(date != null ? date : DateTime.Now);
            return dlc.GetPOD(dt);
        }

        public Planet GetPlanet(string planet_name)
        {
            return dlc.GetPlanet(planet_name);
        }

        public IEnumerable<BE.Search.Item> SearchPlanet(string search)
        {
            return dlc.GetSearchResult(search);
        }

        public IEnumerable<Astroid> GetNearEarthAstroid(DateTime from, DateTime until, float min, float max, bool? isDengerous)
        {
            return dlc.GetNearEarthAstroid(from, until, min, max, isDengerous);
        }

        public List<BE.SSPanel> GetSSPlanets()
        {
            return dlc.GetSSPlanets();
        }
    }
}
