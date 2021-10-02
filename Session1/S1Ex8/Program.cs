using System;

namespace S1Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Surroundwith surroundwith = new Surroundwith();
            Console.WriteLine("Hello World!");
            Console.WriteLine(surroundwith.SurroundWith("<<>>","Heyman"));
        }
    }
}