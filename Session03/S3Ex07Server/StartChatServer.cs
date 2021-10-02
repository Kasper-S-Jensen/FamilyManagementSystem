using System;

namespace S3Ex07Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatServer server = new ChatServer();
               server.Start();
        }
    }
}