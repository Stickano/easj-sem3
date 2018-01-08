using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace easj_sem3_tcp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Loopback;
            TcpListener listen = new TcpListener(ip, 9999);
            
            listen.Start();
            Console.WriteLine("Server Started");
            
            try
            {
                while (true)
                {
                    TcpClient client = listen.AcceptTcpClient();
                    TcpServer server = new TcpServer(ref client);
                    Task.Factory.StartNew(() => server.Run());

                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                listen.Stop();
            }
        }
    }
}