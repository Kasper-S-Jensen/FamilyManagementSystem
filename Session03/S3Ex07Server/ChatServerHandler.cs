using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace S3Ex07Server
{
    public class ChatServerHandler
    {
        private ConnectionPool pool;
        private TcpClient client;
        private NetworkStream stream;
        private Message _message;


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
                
               

                Message backAgain = JsonSerializer.Deserialize<Message>(s);
                Console.WriteLine(backAgain);
                if (s.Contains("exit"))
                {
                    pool.RemoveConnection(this);
                    client.Close();
                    stream.Close();
                    
                    break;
                }

                //broadcast message to all clients
                pool.Broadcast(s);
            }
            
        }

        public void SendMessageToClient(string s)
        {
            byte[] dataToClient = Encoding.UTF8.GetBytes(s);
            stream.Write(dataToClient, 0, dataToClient.Length);
        }
    }
}