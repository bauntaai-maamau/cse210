using System;

class Program
{
    static void Main(string[] args)
    {
    
        // Create multiple videos
        Video video1 = new Video("Piano Basics", "Peter Parker", 1200);
        Video video2 = new Video("30 Minutes Aerobic Exercise", "Bruce Wayne", 1830);
        Video video3 = new Video("How to loose 20lbs in 2 days!", "Anne Frazer", 1830);



        // Add comments to video1
        Comment comment1 = new Comment("Atanroroa", "I found it a bit difficult as a beginner. Could use more basic examples.");
        Comment comment2 = new Comment("Kaititaake", "I took lessons for ten years as a kid/teen and remember notes but I do not remember how to play. Your course is great. I am so glad I found it. Thanks so much. ");
        video1.AddComment(comment1);
        video1.AddComment(comment2);



        // Add comments to video2
        Comment comment3 = new Comment("Kaeroa", "This workout is perfect! Quick, effective, and easy to do at home—exactly what I needed!");
        Comment comment4 = new Comment("Tineta", "That was great! iv been getting into fitness for about 5 weeks now, (first time in my life) and i was even surprised i could do the hole video plus  the warm up! Thank you so much for this video cant wait to try out more!");
        Comment comment5 = new Comment("Holloway", "This is helping through my depression! so grateful to you.");
        Comment comment6 = new Comment("John Cena", "Awesome 30 minutes. Love the variety. Thank you!");
        video2.AddComment(comment3);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);



        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };



        // Display all video info and comments
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------\n");
        }
    }

}


