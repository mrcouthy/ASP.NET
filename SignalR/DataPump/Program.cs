using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace DataPump
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
