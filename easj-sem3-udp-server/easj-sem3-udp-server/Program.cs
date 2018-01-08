using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace easj_sem3_udp_server
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            UdpClient server = new UdpClient(9999);
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint endPoint = new IPEndPoint(ip, 9999);

            try
            {
                Console.WriteLine("Server is Blocked");
                while (true)
                {
                    Byte[] receiveByte = server.Receive(ref endPoint);
                    string convertByte = Encoding.ASCII.GetString(receiveByte);

                    Console.WriteLine("Client: " + convertByte);

                    Byte[] sendByte = Encoding.ASCII.GetBytes(convertByte);
                    server.Send(sendByte, sendByte.Length, endPoint);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}