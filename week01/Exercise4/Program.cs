using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        var numbers = new List<int>();

        int sum = 0;
        int count = 0;
        int max = int.MinValue;
        int min = int.MaxValue;
        float average = 0.0f;

        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
            sum += number;
            count++;
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
            average = (float)sum / count;
        }
        Console.WriteLine($"The sum is {sum}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The maximum is: {max}.");
        Console.WriteLine($"The minimum is: {min}.");
        numbers.Sort();
        Console.Write("The sorted list is: ");
        foreach (var n in numbers)
        {
            Console.Write($"\n{n}");
        }
        Console.WriteLine();
    }
}