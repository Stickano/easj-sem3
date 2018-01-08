using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace easj_sem3_udp_broadcaster
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int PORT = 9999;
            UdpClient socket = new UdpClient();
            
            socket.EnableBroadcast = true;
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, PORT);

            while (true)
            {
                string message = "The time is " + DateTime.Now;
                byte[] buffer = Encoding.ASCII.GetBytes(message);

                socket.Send(buffer, buffer.Length, endPoint);
                Console.WriteLine("Message sent to {0}:{1}",endPoint.Address, PORT);
                Thread.Sleep(5000);
            }
        }
    }
}