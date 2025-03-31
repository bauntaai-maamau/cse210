using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a video object
        Video myvideo = new Video("How to program in C#", "Peter Parker", 600);

        // Add some comments to the video
        myvideo.AddComment(new Comment("Jane", "Great tutorial! Very helpful."));
        myvideo.AddComment(new Comment("Alice", "I learned so much, thank you!"));
        myvideo.AddComment(new Comment("Bob", "Nice explanation, but could use more examples."));

        // Display all the comments
        myvideo.DisplayVideoInfo();

        Console.WriteLine();
    }

}



