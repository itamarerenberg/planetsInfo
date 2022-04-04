using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var dlc = new DLClass();
            //DateTime s = new DateTime(1999, 12, 1);
            //DateTime e = new DateTime(2020, 12, 1);
            //var a = dlc.GetNearEarthAstroid(s,e);
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            dlc.GetSearchResult("moon");
            Console.ReadKey();
        }
    }
}
