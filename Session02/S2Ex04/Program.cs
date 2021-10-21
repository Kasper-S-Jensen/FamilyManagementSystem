using System;

namespace S2Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitingRoom waitingRoom = new WaitingRoom();
           
            Patient p1 = new Patient(waitingRoom);
            Patient p2 = new Patient(waitingRoom);
            Patient p3 = new Patient(waitingRoom);
            Patient p4 = new Patient(waitingRoom);
            waitingRoom.RunWaitingRoom();
            


        }
    }
}