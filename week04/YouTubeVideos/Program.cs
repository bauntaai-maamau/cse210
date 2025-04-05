using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a video object
        Video myvideo = new Video("How to program in C#", "Peter Parker", 600);

        // Add some comments to the video
        Comment myComment1 = new Comment("Jane", "Great tutorial! Very helpful.");
        Comment myComment2 = new Comment("Alice", "I learned so much, thank you!");
        Comment myComment3 = new Comment("Bob", "Nice explanation, but could use more examples.");


        //Add comment to the video
        myvideo.AddComment(myComment1);
        myvideo.AddComment(myComment2);
        myvideo.AddComment(myComment3);


        // Display all the comments
        myvideo.DisplayVideoInfo();

        Console.WriteLine();

    }

}



