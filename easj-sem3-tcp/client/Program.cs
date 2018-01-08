using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace client
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpClient server = new TcpClient(ip.ToString(), 9999);
            
            using (Stream stream = server.GetStream())
            using (StreamReader reader = new StreamReader(stream))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.AutoFlush = true;
                Console.WriteLine("Connected to server");
                while (true)
                {
                    string message = Console.ReadLine();
                    writer.WriteLine(message);

                    if (message.ToLower().Equals("exit"))
                        break;

                    string answer = reader.ReadLine();
                    Console.WriteLine("Server: " + answer);
                }
            }
        }
    }
}