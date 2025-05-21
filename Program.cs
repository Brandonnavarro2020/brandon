using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter your name: ");
        string? name = Console.ReadLine();

        int number;
        while (true)
        {
            Console.Write("Please enter your favorite number: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out number))
                break;
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        int square = number * number;
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
