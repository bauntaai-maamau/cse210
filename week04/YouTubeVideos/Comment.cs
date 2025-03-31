using System;
using System.Security.Cryptography.X509Certificates;

public class Comment
{
    public string _author;
    public string _text;
    

    
    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

}