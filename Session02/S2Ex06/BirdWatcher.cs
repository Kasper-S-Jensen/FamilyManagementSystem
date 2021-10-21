using System;

namespace S2Ex06
{
    public class BirdWatcher
    {
        public Bird Bird { get; set; }
        public string Name { get; set; }


        public BirdWatcher(Bird bird,string name)
        {
            Bird = bird;
            bird.BirdBehavior += ReactToBird;
            Name = name;
        }

        public void ReactToBird(string behaviour)
        {
            if (behaviour.Equals("Bird flaps wings"))
            {
                Console.WriteLine($"{Name} says: Such flapping!");
            }
            else if (behaviour.Equals("Bird sings"))
            {
                Console.WriteLine($"{Name} says: Such song!");
            }
            else if (behaviour.Equals("Bird does mating dance"))
            {
                Console.WriteLine($"{Name} says: Such dancing!");
            }
            
        }
    }
}