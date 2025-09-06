using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine();
        
        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(name, squaredNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }
        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}.");
        }
        
    }
}