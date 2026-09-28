using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold the videos
        List<Video> videos = new List<Video>();

        // Create the first video and add comments
        Video video1 = new Video("The Beauty of Nature", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Amazing video!"));
        video1.AddComment(new Comment("Bob", "I love nature too!"));
        video1.AddComment(new Comment("Eve", "So relaxing to watch."));
        videos.Add(video1);

        // Create the second video and add comments
        Video video2 = new Video("The Wonders of Space", "Jane Smith", 600);
        video2.AddComment(new Comment("Charlie", "Space is fascinating!"));
        video2.AddComment(new Comment("Dave", "Great visuals!"));
        video2.AddComment(new Comment("Frank", "I want to learn more about this."));
        videos.Add(video2);

        // Create the third video and add comments
        Video video3 = new Video("The Art of Cooking", "Chef Alex", 450);
        video3.AddComment(new Comment("Eve", "Yummy recipes!"));
        video3.AddComment(new Comment("Frank", "Can't wait to try this!"));
        video3.AddComment(new Comment("Grace", "Cooking is an art indeed."));
        videos.Add(video3);

        // Display information about each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}