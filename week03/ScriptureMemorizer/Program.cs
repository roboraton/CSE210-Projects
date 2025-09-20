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

            // Mostrar referencia y palabras
            Console.WriteLine($"{reference.GetDisplayText()}");
            Console.WriteLine(string.Join(" ", words.Select(w => w.GetDisplayText())));
            Console.WriteLine("\nPresiona Enter para ocultar palabras o escribe 'quit' para salir.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Ocultar 3 palabras aleatorias
            HideRandomWords(words, 3);

            // Verificar si ya están todas ocultas
            if (words.All(w => w.IsHidden()))
            {
                Console.Clear();
                Console.WriteLine($"{reference.GetDisplayText()}");
                Console.WriteLine(string.Join(" ", words.Select(w => w.GetDisplayText())));
                Console.WriteLine("\n¡Todas las palabras están ocultas! Programa finalizado.");
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
            visibleWords.RemoveAt(index); // evitar ocultar la misma palabra
        }
    }
}