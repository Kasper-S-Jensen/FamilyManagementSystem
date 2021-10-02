using System;
using System.Net.Sockets;
using System.Text;

namespace S3Ex05Server
{
    public class ChatServerHandler
    {
        private ConnectionPool pool;
        private TcpClient client;
        private NetworkStream stream;


        public ChatServerHandler(TcpClient client, ConnectionPool pool)
        {
            this.client = client;
            this.pool = pool;

            // streams setter
            stream = client.GetStream();
        }

        public void Start()
        {
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

                //broadcast message to all clients
                pool.Broadcast(s);
            }
        }

        public void SendMessageToClient(string s)
        {
            byte[] dataToClient = Encoding.UTF8.GetBytes($"Broadcasting {s}");
            stream.Write(dataToClient, 0, dataToClient.Length);
        }
    }
}