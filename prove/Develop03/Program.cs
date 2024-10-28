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

class Reference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse.HasValue 
            ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}" 
            : $"{Book} {Chapter}:{StartVerse}";
    }
}

class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(Reference.ToString());
        foreach (Word word in Words)
        {
            Console.Write(word.IsHidden ? "____ " : word.Text + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        var wordsToHide = Words.Where(word => !word.IsHidden).OrderBy(x => rand.Next()).Take(count).ToList();
        foreach (Word word in wordsToHide)
        {
            word.IsHidden = true;
        }
    }

    public bool IsFullyHidden()
    {
        return Words.All(word => word.IsHidden);
    }
}

class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }
}
