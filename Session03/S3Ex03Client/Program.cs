using System;
using System.Net.Sockets;
using System.Text;

namespace S3Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting client..");

            TcpClient client = new TcpClient("127.0.0.1", 5000);

            NetworkStream stream = client.GetStream();

            string input="";
            while (input!="exit")
            {
                input = Console.ReadLine();
                //write
                byte[] dataToServer = Encoding.UTF8.GetBytes(input);
                stream.Write(dataToServer,0,dataToServer.Length);
            
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