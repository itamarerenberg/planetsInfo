using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class SearchItem
    {
        
        public string title { get; set; }
        public string nasa_id { get; set; }
        public DateTime date_created { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string imgUri { get; set; }
    }
}
