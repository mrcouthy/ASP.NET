using System;
using Microsoft.Owin.Hosting;
 

namespace SignalR.Hosting.Self.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            const string url = "http://localhost:8080/";
            using (WebApp.Start(url))
            {
                Console.WriteLine("Started server on {0}", url);
                Console.ReadLine();
            }
        }
    }
}