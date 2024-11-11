using System;
using System.Threading;

namespace MindfulnessApp
{
    public class BreathingActivity : MindfulnessActivity
    {
        public override void RunActivity()
        {
            StartActivity("Breathing", "Follow the prompts to pace your breathing.");

            for (int i = 0; i < duration; i += 4)
            {
                Console.WriteLine("Breathe in...");
                Thread.Sleep(2000);
                Console.WriteLine("Breathe out...");
                Thread.Sleep(2000);
            }

            Console.WriteLine("Well done! You completed the breathing activity.");
        }
    }
}