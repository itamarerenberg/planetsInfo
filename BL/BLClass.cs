using BE;
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
        //picture of the day by immaga
        public string PoD()
        {
            throw new NotImplementedException();
        }

        
        public PlanetInfo GetPlanetInfo(string pname)
        {
            throw new NotImplementedException();
        }

        public PlanetInfo SearchByImage(string imUrl)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PlanetInfo> qurey(DateTime from, DateTime until, float diameter=0, bool isDengerous=false)
        {
            throw new NotImplementedException();
        }
    }
}
