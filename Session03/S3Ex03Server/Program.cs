using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace S3Ex03Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server starting..");
            
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 5000);
            listener.Start();
            Console.WriteLine("Server started..");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();

                Console.WriteLine("Client connected");
                NetworkStream stream = client.GetStream();

                while (client.Connected)
                {
                    //read
                    byte[] dataFromClient = new byte[1024];
                    int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                    string s = Encoding.UTF8.GetString(dataFromClient, 0, bytesRead);
                    Console.WriteLine(s);
                
                    //respond
                    byte[] dataToClient = Encoding.UTF8.GetBytes($"Returning {s}");
                    stream.Write(dataToClient,0,dataToClient.Length);
                
                    
 
                }
                //close connection
                client.Close();

            }
            
            
            
        }
    }
}