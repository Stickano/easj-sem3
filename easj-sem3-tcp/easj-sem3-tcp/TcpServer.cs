using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace easj_sem3_tcp
{
    public class TcpServer
    {
        private TcpClient client;
        
        public TcpServer(ref TcpClient client)
        {
            this.client = client;
        }

        public void Run()
        {
            ConnectionHandler(client);
        }

        void ConnectionHandler(TcpClient client)
        {
            string clientInfo = client.Client.RemoteEndPoint.ToString();
            Console.WriteLine("Incomming commection from: " + clientInfo);
            
            using (Stream stream = client.GetStream())
            using (StreamWriter writer = new StreamWriter(new BufferedStream(stream)))
            using (StreamReader reader = new StreamReader(stream))
            {
                writer.AutoFlush = true;
                while (true)
                {
                    string answer;
                    answer = reader.ReadLine();
                    Console.WriteLine("Client: " + answer);
                    
                    if (answer.ToLower().Equals("exit"))
                        break;
                    
                    string[] words = answer.Split(' ');
                    
                    if (answer.ToLower().Equals("help"))
                    {
                        writer.WriteLine("A useful list of commands");
                    }
                    
                    writer.WriteLine(answer.ToUpper());
                }
                
                stream.Close();
            }
        }
    }
}