using System;

class Program
{
    static void Main(string[] args)
    {
        Scriptures scriptures = new Scriptures();
        var (reference, text) = scriptures.GetRandomScripture();

        List<Word> words = text.Split(' ')
            .Select(word => new Word(word))
            .ToList();


        while (true)
        {
            Console.Clear();

            Console.WriteLine($"{reference.GetDisplayText()}");
            Console.WriteLine(string.Join(" ", words.Select(w => w.GetDisplayText())));
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            HideRandomWords(words, 3);

            if (words.All(w => w.IsHidden()))
            {
                Console.Clear();
                Console.WriteLine($"{reference.GetDisplayText()}");
                Console.WriteLine(string.Join(" ", words.Select(w => w.GetDisplayText())));
                Console.WriteLine("\nAll words are hidden! Program finished.");
                break;
            }
        }
    }
    static void HideRandomWords(List<Word> words, int count)
    {
        Random random = new Random();
        var visibleWords = words.Where(w => !w.IsHidden()).ToList();

       
        int toHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < toHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
}