using System;
using System.Threading;

namespace S3Ex07Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatClient client = new ChatClient();
            client.ClientRun();
           
        }
    }
}