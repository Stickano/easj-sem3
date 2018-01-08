using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace client
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Any;
            UdpClient client = new UdpClient("127.0.0.1", 9999);
            IPEndPoint endPoint = new IPEndPoint(ip, 9999);

            string message = Console.ReadLine();
            while (true)
            {
                Byte[] sendByte = Encoding.ASCII.GetBytes(message);
                client.Send(sendByte, sendByte.Length);

                Byte[] receiveBytes = client.Receive(ref endPoint);
                string convertByte = Encoding.ASCII.GetString(receiveBytes);
                Console.WriteLine("Server: " + convertByte);

                message = Console.ReadLine();
            }
        }
    }
}