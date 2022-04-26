using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DL
{
    public static class DLConfig
    {
        private static string config_file_path = @"..\..\..\DL/DLConfig.xml";
        public static XElement root;

        static DLConfig()
        {
            root = XElement.Load(config_file_path);
        }

        /// <summary>
        /// get nasa's API key
        /// </summary>
        /// <param name="userName">corrently not in use - for forther extentions</param>
        public static string get_nasa_API_key(string userName = "")
        {
            return root.Element("NASA_API_KEY").Value;
        }
        public static string get_IMAGGA_API_key(string userName = "")
        {
            return root.Element("IMAGGA_API_KEY").Value;
        }
        public static string get_IMAGGA_API_SECRET(string userName = "")
        {
            return root.Element("IMAGGA_API_SECRET").Value;
        }
        public static string get_IMAGGA_API_AUTH(string userName = "")
        {
            return root.Element("IMAGGA_API_AUTH").Value;
        }
    }
}
