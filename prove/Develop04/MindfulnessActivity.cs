using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class MindfulnessActivity
    {
        protected int duration;

        public void StartActivity(string activityName, string description)
        {
            Console.WriteLine($"\n--- {activityName} ---\n{description}");
            Console.Write("Enter duration in seconds: ");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready...");
            ShowSpinner(3);
        }

        protected void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds * 4; i++)
            {
                Console.Write("/\b-\b\\\b|\b");
                Thread.Sleep(250);
            }
            Console.WriteLine();
        }

        public abstract void RunActivity();
    }
}
