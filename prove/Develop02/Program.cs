using System;


public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToShortDateString(); 
    }

    public override string ToString()
    {
        return $"{Date} - {Prompt}: {Response}";
    }
}

public class Journal
{
    private List<Entry> entries = new List<Entry>();


    private static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void AddEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)]; 
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        entries.Add(new Entry(prompt, response)); 
    }


    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter a filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile()
    {
        Console.Write("Enter a filename to load: ");
        string filename = Console.ReadLine();
        entries.Clear(); 
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[1], parts[2]) { Date = parts[0] };
                entries.Add(entry);
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";

        while (choice != "5") 
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry(); 
                    break;
                case "2":
                    journal.DisplayEntries(); 
                    break;
                case "3":
                    journal.SaveToFile(); 
                    break;
                case "4":
                    journal.LoadFromFile(); 
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
