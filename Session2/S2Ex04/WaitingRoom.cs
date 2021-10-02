using System;
using System.Threading;

namespace S2Ex04
{
    public class WaitingRoom
    {
        public Action<int> NumberChange { get; set; }
        private int currentNumber=0;
        private int ticketCount=0;

        public void RunWaitingRoom()
        {
            while (currentNumber<ticketCount)
            {
                
                currentNumber++;
                Console.WriteLine("DIIIIING!");
                Console.WriteLine($"Patientnumber {currentNumber} can now enter");
                NumberChange.Invoke(currentNumber);
                Thread.Sleep(1000);
            }
        }

        public int DrawNumber()
        {
            ticketCount++;
            return ticketCount;
        }

    }
}