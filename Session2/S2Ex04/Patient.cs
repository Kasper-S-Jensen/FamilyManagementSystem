using System;

namespace S2Ex04
{
    public class Patient
    {
        public int numberInQueue { get; set; }
        public WaitingRoom WaitingRoom { get; set; }

        public Patient(WaitingRoom waitingRoom)
        {
            WaitingRoom = waitingRoom;
            numberInQueue = waitingRoom.DrawNumber();
            waitingRoom.NumberChange += ReactToNumber;
        }

        public void ReactToNumber(int ticketNumber)
        {
            Console.WriteLine($"Patient with ticketnumber {numberInQueue} looks up");
            if (numberInQueue==ticketNumber)
            {
                Console.WriteLine($"Patient with ticketnumber {numberInQueue} Walks in to the doctor's room");
                WaitingRoom.NumberChange -= ReactToNumber;
            }
            else
            {
                Console.WriteLine($"Patient with ticketnumber {numberInQueue} goes back to looking at phone");
            }
        }
        
    }
}