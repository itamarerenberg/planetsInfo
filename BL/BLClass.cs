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
        DLClass dlc;
        public BLClass()
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

        public Astroid SearchByImage(string imUrl)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Astroid> qurey(DateTime from, DateTime until, float min, float max, bool? isDengerous)
        {
            return dlc.GetNearEarthAstroid(from, until, min, max, isDengerous);
        }

        public List<string> GetSSPlanets()
        {
            return dlc.GetSSPlanets();
        }
    }
}
