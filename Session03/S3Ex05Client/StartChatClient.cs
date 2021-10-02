using System;
using System.Threading;

namespace S3Ex05Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatClient client = new ChatClient();
            Thread thread = new Thread(() => client.ClientRun());
            thread.Start();
        }
    }
}