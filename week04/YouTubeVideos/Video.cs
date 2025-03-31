using System;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthsInSeconds;
    private List<Comment> _comments;



    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthsInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }


    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to display all the comments for this video
    public void DisplayComments()
    {
        if (_comments.Count == 0)
        {
            Console.WriteLine("No comments to display.");
            return;
        }

        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment._author}: {comment._text}");
        }
    }



    // Method to display the video's details
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthsInSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}\n");
        DisplayComments();
    }

}