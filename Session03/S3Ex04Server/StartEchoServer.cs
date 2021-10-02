using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace S3Ex04Server
{
    class Program
    {
        static void Main(string[] args)
        {
            EchoServer server = new EchoServer();
            server.Start();
        }
    }
}