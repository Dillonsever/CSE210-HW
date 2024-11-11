using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nMindfulness Activities");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                MindfulnessActivity activity = choice switch
                {
                    "1" => new BreathingActivity(),
                    "2" => new ReflectionActivity(),
                    "3" => new ListingActivity(),
                    "4" => null,
                    _ => throw new InvalidOperationException("Invalid choice.")
                };

                if (choice == "4") break;
                activity?.RunActivity();
            }
        }
    }
}
