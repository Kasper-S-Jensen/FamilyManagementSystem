using System;

namespace S2Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            BirdWatcher watcher1 = new BirdWatcher(bird,"bob");
            BirdWatcher watcher2 = new BirdWatcher(bird,"Henrich");
            BlindBirdWatcher watcher3 = new BlindBirdWatcher(bird,"Blind Jessica");
            bird.RunBird();
            
        }
    }
}