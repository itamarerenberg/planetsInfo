using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    /// <summary>
    /// picture of the day
    /// </summary>
    public class POD
    {
        public string picName { get; set; }
        public string picUrl { get; set; }
        public string explenation { get; set; }
        public DateTime date { get; set; }
        public string imageCredit { get; set; }
        public string tomorrowPic { get; set; }
    }
}
