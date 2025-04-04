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
    public void Hide()
    {
        _isHidden = true;
    }

    //Hide the word
    public void Show()
    {
        _isHidden = false;
    }

    //Check if the word is hidden
    public bool IsHidden
    {
        get
        {
            return _isHidden;
        }
    }

    //Get the word or hide if needed
    public string Text
    {
        get
        {
            return _isHidden ? "___" : _text;
        }
    }
}