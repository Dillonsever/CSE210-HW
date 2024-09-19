using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string user_grade = Console.ReadLine();
        int number = int.Parse(user_grade);
        string letter = "";

        if ( number >= 90)
            {
                letter = "A";
            }
        else if (number >= 80 )
            {

                letter = "B";
            }
        else if (number >= 70 )
            {
                letter = "C";
            }
        else if (number >= 60 )
            {
                letter = "D";
            }
        else
            {
                letter = "F";
            }

        Console.WriteLine($"{letter}");

        if ( number >= 70)
        {
            Console.WriteLine("Congrats you passed the class!!");
        }
        else
        {
            Console.WriteLine("Fail, Maybe Next Time");
        }      
    }
}