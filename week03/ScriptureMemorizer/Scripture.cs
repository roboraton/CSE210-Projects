
public class Scriptures
{
    private List<(Reference, string)> _scriptures;

    public Scriptures()
    {
        _scriptures = new List<(Reference, string)>
        {
            (
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding."
            ),
            (
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
            )
            ,
            (
                new Reference("Philippians", 4, 13),
                "I can do all this through him who gives me strength."
            ),
            (
                new Reference("Psalm", 23, 1, 4),
                "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters. He restoreth my soul: he leadeth me in the paths of righteousness for his name's sake. Yea, though I walk through the valley of the shadow of death, I will fear no evil: for thou art with me; thy rod and thy staff they comfort me."
            ),
            (
                new Reference("Romans", 8, 28),
                "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."
            ),
            (
                new Reference("1 Nephi", 3, 7),
                "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
            )
        };
    }

    // Randomly select a scripture
    public (Reference, string) GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
