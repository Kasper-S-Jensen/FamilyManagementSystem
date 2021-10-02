using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace S3Ex04Server
{
    public class EchoServer
    {
        public void Start()
        {
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 5000);
            listener.Start();
            Console.WriteLine("Server connected...");
            while (true)
            {
                //Wait for a client to connect
                TcpClient newClient = listener.AcceptTcpClient();
                Console.WriteLine("New client connected");

                //create a thread to handle the connected client
                ServerSocketHandler ssh = new ServerSocketHandler(newClient);
                Thread clientThread = new Thread(() => ssh.Start());
                clientThread.Start();
            }
        }
    }
}