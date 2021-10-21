using System;
using System.Threading;

namespace S2Ex06
{
    public class Bird
    {
        public Action<string> BirdBehavior;
        public string CurrentBehavior;

        public void RunBird()
        {
            Random rand = new Random();
            string[] array = {"Bird flaps wings", "Bird sings", "Bird does mating dance"};
        
            for (int i = 0; i < 10; i++)
            {
                int randomIndex = rand.Next(0,array.Length);
                CurrentBehavior = array[randomIndex];
                Console.WriteLine(array[randomIndex]);
                BirdBehavior.Invoke(CurrentBehavior);
                Thread.Sleep(1000);
            }
        }

    }
}