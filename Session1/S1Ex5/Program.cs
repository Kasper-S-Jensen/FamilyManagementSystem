using System;
using MathLib;
namespace S1Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new();
            Console.WriteLine(calculator.Add(4, 6));

            int[] numbers = new[] {1, 2, 3, 4, 5};
            Console.WriteLine(calculator.Add(numbers));
        }
    }
}