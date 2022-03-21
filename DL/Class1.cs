using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Class1
    {
        
















        public static void Main(string[] args)
        {
            string apiKey="";

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
