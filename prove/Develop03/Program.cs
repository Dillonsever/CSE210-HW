using System;
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd, I shall not want."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me.")
        };

        Random rand = new Random();
        Scripture selectedScripture = scriptureLibrary[rand.Next(scriptureLibrary.Count)];

        while (!selectedScripture.IsFullyHidden())
        {
            Console.Clear();
            selectedScripture.Display();
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            selectedScripture.HideRandomWords(3);
        }

        Console.WriteLine("All words are hidden. Good job memorizing!");
    }
}
