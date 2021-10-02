using System;

namespace S1Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Biggestdif biggestdif = new Biggestdif();
            Console.WriteLine("Hello World!");
            int[] array = {30, 2, 3, 100, 8};
            Console.WriteLine(biggestdif.LargestDiff(array));
        }
    }
}