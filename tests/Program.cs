using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string apiKey = "P8NQXJLV9cTtfJBeIxONVhKCasipTQ0JJsD0wi1f";

            var client = new RestClient("https://api.nasa.gov/planetary/apod");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("api_key", apiKey);

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            Console.ReadLine();
        }
    }
}
