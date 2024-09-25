using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        string magic_number = Console.ReadLine();
        int number = int.Parse(magic_number);
        int i = 1;

        while( i == 1 ) {

            Console.WriteLine("What is your guess? ");
            string g_number = Console.ReadLine();
            int guess_number = int.Parse(g_number);

            if ( number >  guess_number)
                {
                Console.WriteLine("Higher");
                }
            else if (number < guess_number )
                {

                    Console.WriteLine("Lower");
                }
            else if (number == guess_number )
                {

                    Console.WriteLine("You've guessed it!");
                    i = 0;
                }

        }


    }
}