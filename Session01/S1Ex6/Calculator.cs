using System;

namespace MathLib
{
    public class Calculator
    {

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Add(int[] array)
        {
            int sum=0;
            foreach (var VARIABLE in array)
            {
                sum += VARIABLE;
            }

            return sum;
        }

        public int InputAdd()
        {
            Console.WriteLine("Enter first number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result is :");
            return First + Second;
        }
    }
}