using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace S3Ex04Client
{
    public class RunClient
    {
        private TcpClient client = new TcpClient("127.0.0.1", 5000);
        NetworkStream stream;

        public void ClientRun()
        {
            Console.WriteLine("Starting client..");
            stream = client.GetStream();


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
    }
}