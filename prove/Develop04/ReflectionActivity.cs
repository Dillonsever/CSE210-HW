using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public class ReflectionActivity : MindfulnessActivity
    {
        private readonly List<string> prompts = new List<string>
        {
            "Think of a time you helped someone.",
            "Recall a time you achieved something difficult.",
            "Think of a recent positive experience.",
            "Recall a moment you felt proud of yourself."
        };

        public override void RunActivity()
        {
            StartActivity("Reflection", "Reflect on the prompt and answer the questions.");

            Random random = new Random();
            Console.WriteLine(prompts[random.Next(prompts.Count)]);

            for (int i = 0; i < duration; i += 5)
            {
                Console.WriteLine("What made this experience meaningful?");
                ShowSpinner(5);
            }

            Console.WriteLine("Reflection complete. Great job!");
        }
    }
}
