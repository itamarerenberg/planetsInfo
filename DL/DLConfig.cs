using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DL
{
    public static class DLConfig
    {
        private static string config_file = @"DLConfig.xml";
        public static XElement root;

        static DLConfig()
        {
            root = XElement.Load(config_file);
        }

        /// <summary>
        /// get nasa's API key
        /// </summary>
        /// <param name="userName">corrently not in use - for forther extentions</param>
        public static string get_nasa_API_key(string userName = "")
        {
            return root.Element("NASA_API_KEY").Value;
        }
    }
}
