using System;
using System.Threading;

namespace S3Ex04Client
{
    class Program
    {
        static void Main(string[] args)
        {
            RunClient client = new RunClient();
            Thread thread = new Thread(() => client.ClientRun());
            thread.Start();
        }
    }
}