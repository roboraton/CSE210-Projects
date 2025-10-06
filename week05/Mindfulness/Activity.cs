using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(_description);
        Console.ResetColor();

        Console.Write("\nEnter duration in seconds: ");
        Console.ForegroundColor = ConsoleColor.Green;
        _duration = int.Parse(Console.ReadLine());
        Console.ResetColor();

        Console.WriteLine("\nGet ready to begin...");
        ShowSpinner(3);
    }


    public void DisplayEndingMessage()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nGreat job!");
        Console.ResetColor();

        ShowSpinner(2);

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        Console.ResetColor();

        ShowSpinner(3);
    }


    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        ConsoleColor[] colors = { ConsoleColor.Cyan, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Magenta };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.ForegroundColor = colors[i % colors.Length];
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Length;
        }
        Console.ResetColor();
    }


    public void ShowContDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public abstract void Run();

}

