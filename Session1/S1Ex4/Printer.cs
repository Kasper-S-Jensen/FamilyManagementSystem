using System;

namespace S1Ex4
{
    public class Printer
    {
        public void NumberPrinter(int limit)
        {
            for (int i = 0; i <= limit; i++)
            {
                if (i % 2 ==0)
                {
                    if (i/2 !=0)
                    {
                        Console.WriteLine(i);
                    }
                    
                }
            }
        }
        public void NumberPrinterUneven(int limit)
        {
            for (int i = 0; i <= limit; i++)
            {
                if (i % 2 !=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void NumberPrinterDivisibleByY(int limit,int divider)
        {
            for (int i = 0; i <= limit; i++)
            {
                if (i % divider ==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}