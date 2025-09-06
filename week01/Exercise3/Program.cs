using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();
        Console.WriteLine("I'm thinking of a number between 1 and 100.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = 0;
        int attempts = 0;

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            attempts++;
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it in {attempts} attempts!");
            }
        }
        while (guess != number);
        Console.Write("Do you want to play again? (yes/no) ");
        string playAgain = Console.ReadLine().ToLower();
        if (playAgain == "yes")
        {
            Main(args);
        }
        else
        {
            Console.WriteLine("Thanks for playing! Goodbye.");
        }
    }
}