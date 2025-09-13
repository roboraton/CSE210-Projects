using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save Journal to file");
            Console.WriteLine("4. Load entries from file");
            Console.WriteLine("5. Delete an entry");
            Console.WriteLine("6. Clear all entries");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option (1-7): ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    string prompt = generator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry
                    {
                        _date = DateTime.Now.ToShortDateString(),
                        _promptText = prompt,
                        _entryText = response
                    };
                    myJournal.AddEntry(newEntry);
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved.");
                    break;

                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded.");
                    break;

                case "5":
                    myJournal.DisplayAll();
                    Console.Write("Enter the entry number to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int indexToDelete))
                    {
                        myJournal.DeleteEntry(indexToDelete - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number.");
                    }
                    break;

                case "6":
                    myJournal.ClearAll();
                    Console.WriteLine("All entries were deleted.");
                    break;

                case "7":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}