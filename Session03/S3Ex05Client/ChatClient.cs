using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace S3Ex05Client
{
    public class ChatClient
    {
        private TcpClient client = new TcpClient("127.0.0.1", 5000);
        NetworkStream stream;

        public void ClientRun()
        {
            Console.WriteLine("Starting client..");
            stream = client.GetStream();

            Thread thread = new Thread(() => listenToServer());
            thread.Start();
            
            string input = "";
            while (input != "exit")
            {
                input = Console.ReadLine();
                //write
                byte[] dataToServer = Encoding.UTF8.GetBytes(input);
                stream.Write(dataToServer, 0, dataToServer.Length);
                if (input.Equals("exit"))
                {
                    client.Close();
                    break;
                }

                //read
                byte[] dataFromServer = new byte[1024];
                int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.UTF8.GetString(dataFromServer, 0, bytesRead);
                Console.WriteLine(response);
            }

            stream.Close();
            client.Close();
        }

        public void listenToServer()
        {
            while (true)
            {
                byte[] dataFromClient = new byte[1024];
                int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                string s = Encoding.UTF8.GetString(dataFromClient, 0, bytesRead);
                if (s.Equals("exit"))
                {
                    client.Close();
                    break;
                }

                Console.WriteLine(s);
            }
        }
    }
}