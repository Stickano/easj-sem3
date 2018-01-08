using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace receiver
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int PORT = 9999;
            using (UdpClient socket = new UdpClient(PORT))
            {
                IPEndPoint ip = new IPEndPoint(0,0);
                while (true)
                {
                    byte[] receive = socket.Receive(ref ip);
                    string message = Encoding.ASCII.GetString(receive, 0, receive.Length);
                    Console.WriteLine("From {0}: {1}",ip.Address,message);			
                }
            }

        }
    }
}