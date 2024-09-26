using System;

class Program
{
    static void Main(string[] args)
    {
        int input = -1;
        List<int> number = new List<int>(); 
        Console.WriteLine("Enter a list of numbers and press 0 when done. ");

        while(input != 0){
            Console.WriteLine("Enter number: ");
            string number_entered = Console.ReadLine();
            input = int.Parse(number_entered); 
            number.Add(input);

        }

        int sum = 0;
        foreach (int num in number)
        {
            sum += num;
        }
        Console.WriteLine("The sum of the numbers is: " + sum);

        if (number.Count > 0)
        {
            double average = number.Average();
            Console.WriteLine("The average of the numbers is: " + average);
        }

        if (number.Count > 0)
        {
            int maxNumber = number.Max();
            Console.WriteLine("The largest number is: " + maxNumber);
        }


            }
}