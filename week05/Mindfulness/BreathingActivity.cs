using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("Breathing", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public override void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowContDown(4);
            Console.Write("Now breathe out...");
            ShowContDown(6);
        }
        DisplayEndingMessage();

    }

}