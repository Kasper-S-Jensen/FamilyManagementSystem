using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Clumps clumps = new Clumps();
            int[] array = new[] {1, 1, 2, 2, 3};
            Console.WriteLine(clumps.ClumpCalculator(array));
        }
    }
}