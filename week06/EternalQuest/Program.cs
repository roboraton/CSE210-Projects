// Included a level score with a level up every 1000 points earned.

using System;
using EternalQuest;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        manager.Start();
    }
}