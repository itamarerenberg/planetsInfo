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
        static DLClass dlc = new DLClass();
        static void Main(string[] args)
        {
            //dlc.Search("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRlR5Fqi_JxLViz9QhPKQxSEhlhah-oyaPvYA&usqp=CAU");
            Console.WriteLine("done!");
            Console.ReadLine();
        }

        public static void TestGetSearchResult()
        {
            dlc.GetSearchResult("moon");
        }

        public static void TestGetNearEarthAstroid()
        {
            DateTime s = new DateTime(1999, 12, 1);
            DateTime e = new DateTime(2020, 12, 1);
            int i = 0;
            foreach(var a in dlc.GetNearEarthAstroid(s, e, 0.2f, 0.7f, null))
            {
                Console.WriteLine(a.ToString());
                Console.WriteLine(i++);
            }
        }
    }
}
