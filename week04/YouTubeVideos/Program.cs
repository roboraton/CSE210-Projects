using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# Fast", "CodeMaster", 420);
        video1.AddComment(new Comment("Alice", "Great explanation, thanks!"));
        video1.AddComment(new Comment("Bob", "I didn't get the part about lists :("));
        video1.AddComment(new Comment("Charlie", "Very clear and straight to the point, greetings from Mexico!"));
        videos.Add(video1);

        Video video2 = new Video("iPhone 16 Review", "TechReviewMX", 560);
        video2.AddComment(new Comment("Diego", "Awesome review, helped me decide."));
        video2.AddComment(new Comment("Eva", "I prefer Android, but nice video."));
        video2.AddComment(new Comment("Frank", "The camera looks amazing."));
        videos.Add(video2);

        Video video3 = new Video("Top 10 Video Games of 2025", "GamerZone", 600);
        video3.AddComment(new Comment("Gabe", "Where is Hollow Knight Silksong?!"));
        video3.AddComment(new Comment("Helen", "Loved the list, great content!"));
        video3.AddComment(new Comment("Ian", "Banjo-Kazooie deserves to be here!"));
        videos.Add(video3);



        Console.WriteLine("\nVideos and Comments List");
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}