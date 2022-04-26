using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using System.Threading;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<object> action = (object obj) =>
            {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                Task.CurrentId, obj,
                Thread.CurrentThread.ManagedThreadId);
            };

            // Create a task but do not start it.
            Task t1 = new Task(action, "alpha");

            // Launch t1 
            t1.Start();
            Console.WriteLine("t1 has been launched. (Main Thread={0})",
                              Thread.CurrentThread.ManagedThreadId);

            int[] arr = { 1, 2, 3 };
            
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
