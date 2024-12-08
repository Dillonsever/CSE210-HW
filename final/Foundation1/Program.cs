using System;

class Program
{
    static void Main()
    {
        Video video1 = new Video("How to Cook Pasta", "Chef John", 600);
        video1.AddComment(new Comment("Alice", "Great recipe!"));
        video1.AddComment(new Comment("Bob", "Tried it, delicious!"));
        video1.AddComment(new Comment("Charlie", "What brand of pasta do you recommend?"));

        Video video2 = new Video("DIY Home Office Setup", "Jason Hansen", 1200);
        video2.AddComment(new Comment("David", "Awesome tips, thanks!"));
        video2.AddComment(new Comment("Emma", "Can you share links to the products?"));
        video2.AddComment(new Comment("Frank", "Loved the cable management advice."));

        Video video3 = new Video("Top 10 Travel Destinations", "Globetrotter Mike", 900);
        video3.AddComment(new Comment("Grace", "Can't wait to visit these places!"));
        video3.AddComment(new Comment("Hank", "How do you decide which destinations make the cut?"));
        video3.AddComment(new Comment("Ivy", "Beautiful video, thanks for sharing!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}


