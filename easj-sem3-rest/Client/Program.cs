using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:52215/Service1.svc/";

            /// Example of receiving data
            //using (HttpClient client = new HttpClient())
            //{
            //    HttpResponseMessage result = client.GetAsync(url + "read").Result;
            //    if (result.IsSuccessStatusCode)
            //    {
            //        HttpContent response = result.Content;
            //        Console.WriteLine(response.ReadAsStringAsync().Result);
            //    }
            //}

            Console.ReadKey();
        }
    }
}
