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
            Console.WriteLine(DL.DLConfig.get_nasa_API_key());
            Console.ReadLine();
        }
    }
}
