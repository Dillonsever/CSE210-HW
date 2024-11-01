using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
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
