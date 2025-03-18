using System;

public class Reference
{
    //variables 
    private string _book;

    private int _chapter;

    private int _verse;

    private int _endVerse;



    //constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }



    //return value
    public string SingleVerseString()
    {
        string text = $"{_book} {_chapter}:{_verse}";
        return text;
    }

    public string MultipleVersesString()
    {
        if (_endVerse == _verse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}