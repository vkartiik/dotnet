using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Demonstration of if-else ladder
        Console.WriteLine("\nUsing if-else ladder:");
        if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

 
        Console.WriteLine("\nUsing switch statement:");
        switch (number)
        {
            case 0:
                Console.WriteLine("The number is zero.");
                break;
            case > 0:
                Console.WriteLine("The number is positive.");
                break;
            case < 0:
                Console.WriteLine("The number is negative.");
                break;
        }
    }
}
