using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference1;


namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client server = new Service1Client();

            /// Create record
            //Object obj = new Object{value = "Hello World"};
            //server.create(obj);

            /// Delete record
            //server.delete("12");

            /// Read single record
            //Console.WriteLine(server.read("12").ToString());

            /// Read all records
            //foreach (Object o in server.readAll())
            //{
            //    Console.WriteLine(o.value);
            //}

            /// Update record
            //Object obj = new Object {value = "Hello World"};
            //server.update(obj, "12");

        }
    }
}
