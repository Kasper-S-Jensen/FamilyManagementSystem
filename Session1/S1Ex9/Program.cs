using System;

namespace S1Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Stringcutter stringcutter = new Stringcutter();
            Console.WriteLine("Hello World!");
            Console.WriteLine(stringcutter.CutTheString("bibliotek", 4));
            
        }
    }
}