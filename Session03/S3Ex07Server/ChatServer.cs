using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace S3Ex07Server
{
    public class ChatServer
    {
        public void Start()
        {
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 5000);
            listener.Start();
            ConnectionPool cp = new ConnectionPool();
            Console.WriteLine("Server connected...");
            while (true)
            {
                //Wait for a client to connect
                TcpClient newClient = listener.AcceptTcpClient();
                Console.WriteLine("New client connected");

                //create a thread to handle the connected client
                ChatServerHandler csh = new ChatServerHandler(newClient, cp);
                cp.AddConnection(csh);
                Thread clientThread = new Thread(() => csh.Start());
                clientThread.Start();
            }
        }
    }
}