using System;
using System.Net.Sockets;
using System.Text;

namespace S3Ex04Server
{
    public class ServerSocketHandler
    {
        private TcpClient client;

        public ServerSocketHandler(TcpClient client)
        {
            this.client = client;
        }

        public void Start()
        {
            // streams setter
            NetworkStream stream = client.GetStream();

            while (true)
            {
                //read
                byte[] dataFromClient = new byte[1024];
                int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                string s = Encoding.UTF8.GetString(dataFromClient, 0, bytesRead);
                Console.WriteLine(s);
                
                if (s.Equals("exit"))
                {
                    client.Close();
                    break;
                }

                //respond
                byte[] dataToClient = Encoding.UTF8.GetBytes($"Returning {s}");
                stream.Write(dataToClient, 0, dataToClient.Length);
                
            }
        }
    }
}