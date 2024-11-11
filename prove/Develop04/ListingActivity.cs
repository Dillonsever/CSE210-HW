using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ListingActivity : MindfulnessActivity
    {
        private readonly List<string> prompts = new List<string>
        {
            "List people you appreciate.",
            "List things you’re grateful for.",
            "List recent kind actions you’ve done.",
            "List things that make you happy."
        };

        public override void RunActivity()
        {
            StartActivity("Listing", "List as many responses as you can.");

            Random random = new Random();
            Console.WriteLine(prompts[random.Next(prompts.Count)]);
            int itemCount = 0;

            DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("Item: ");
                Console.ReadLine();
                itemCount++;
            }

            Console.WriteLine($"You listed {itemCount} items. Great job!");
        }
    }
}
