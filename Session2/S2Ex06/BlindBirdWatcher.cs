using System;

namespace S2Ex06
{
    public class BlindBirdWatcher
    {
        public Bird Bird { get; set; }
        public string Name { get; set; }


        public BlindBirdWatcher(Bird bird, string name)
        {
            Bird = bird;
            Name = name;
            bird.BirdBehavior += ReactToBird;
        }

        public void ReactToBird(string behaviour)
        {
            if (behaviour.Equals("Bird flaps wings"))
            {
                Console.WriteLine($"{Name} says: nothing");
            }
            else if (behaviour.Equals("Bird sings"))
            {
                Console.WriteLine($"{Name} says: Such song i can hear amazingly well!");
            }
            else if (behaviour.Equals("Bird does mating dance"))
            {
                Console.WriteLine($"{Name} says: I hear some odd noises!");
            }
        }
    }
}