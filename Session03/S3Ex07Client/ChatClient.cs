using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;


namespace S3Ex07Client
{
    
    public class ChatClient
    {
        private TcpClient client = new TcpClient("127.0.0.1", 5000);
        NetworkStream stream;
        private Message _message;

        public void ClientRun()
        {
            Console.WriteLine("Starting client..");
            stream = client.GetStream();

            Thread thread = new Thread(() => ListenToServer());
            thread.Start();
            
            
            while (true)
            {
                var input="";
                Console.WriteLine("Write message: ");
                input = Console.ReadLine();
               
                _message = new Message(input);
                string objAsJSON = JsonSerializer.Serialize(_message);
                //write
                byte[] dataToServer = Encoding.UTF8.GetBytes(objAsJSON);
                stream.Write(dataToServer, 0, dataToServer.Length);
               
                if (input.Equals("exit"))
                {
                    Environment.Exit(Environment.ExitCode);
                }
               
            }
        }

        public void ListenToServer()
        {
            while (true)
            {
                byte[] dataFromClient = new byte[1024];
                int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                string s = Encoding.UTF8.GetString(dataFromClient, 0, bytesRead);
                Message backAgain = JsonSerializer.Deserialize<Message>(s);
                if (backAgain.Text.Contains("exit"))
                {
                    client.Close();
                    break;
                }
                
                backAgain = JsonSerializer.Deserialize<Message>(s);
                Console.WriteLine(backAgain);
            }
        }
    }
}