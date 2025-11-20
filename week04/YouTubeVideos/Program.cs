using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Mistborn: The Final Empire", "Brandon Sanderson", 60);
        video1._comments.Add(new Comments("Hyrum", "Amazing book"));
        video1._comments.Add(new Comments("Joe", "So cool i love it"));
        video1._comments.Add(new Comments("Chole", "Best book ever"));

        Video video2 = new Video("The Way of Kings", "Brandon Sanderson", 120);
        video2._comments.Add(new Comments("eliza", "Wait thats crazy"));
        video2._comments.Add(new Comments("mike", "I need to read this"));
        video2._comments.Add(new Comments("venus", "So good"));

        Video video3 = new   Video("The Hobbit", "J.R.R. Tolkien", 90);
        video3._comments.Add(new Comments("lee", "was not expecting that"));
        video3._comments.Add(new Comments("anna", "A classic"));
        video3._comments.Add(new Comments("lynne", "Not a fan"));
        List<Video> videos = new List<Video>() { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._videoLength} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentsNum()}");
            Console.WriteLine("Comments:");
            foreach (Comments comment in video._comments)
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}