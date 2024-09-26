using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string username = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(username, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your username?");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string username, int squaredNumber)
    {
        Console.WriteLine($"{username}, the square of your favorite number is: {squaredNumber}");
    }
}
