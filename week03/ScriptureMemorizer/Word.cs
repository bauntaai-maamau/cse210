using System;
using System.Runtime.CompilerServices;

public class Word
{
    //variables
    private string _text;
    private bool _isHidden;



    //constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }



    //Hide the word
    public void Hide() => _isHidden = true;

    //Check if the word is hidden
    public bool IsHidden => _isHidden;

    //Get the word or hide if needed
    public string Text
    {
        get
        {
            return _isHidden ? "_____" : _text;
        }
    }
}