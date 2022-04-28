using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetsInfo.Model
{
    public class FilterAstroParams_M
    {
        public static DateTime DefaultFrom = DateTime.Now - new TimeSpan(days: 7, 0, 0, 0);
        public static DateTime DefaultUntil = DateTime.Now;
        public static float DefaultMinDiameter = 0;
        public static float DefaultMaxDiameter = float.MaxValue;
        public static bool? DefaultIsDengarous = null;


        public DateTime from = DefaultFrom;
        public DateTime until = DefaultUntil;
        public float min_diameter = DefaultMinDiameter;
        public float max_diameter = DefaultMaxDiameter;
        public bool? isDengarouse = DefaultIsDengarous;
    }
}
