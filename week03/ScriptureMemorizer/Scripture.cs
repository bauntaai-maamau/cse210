using System;

public class Scripture
{
    //variables
    private Reference _reference;
    private List<Word> _words;


    //Constructor
    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = scriptureText.Split(" ").Select(word => new Word(word)).ToList();
    }



    public bool HideRandomWord()
    {
        //get a random word index that is not fully hidden
        Random random = new Random();
        var hiddenWords = _words.Where(w => !w.IsHidden).ToList();

        if (!hiddenWords.Any())
        {
            return false;
        }

        //randomly select a word to hide
        var wordToHide = hiddenWords[random.Next(hiddenWords.Count)];
        wordToHide.Hide();
        return true;
    }

    //display the current scripture with reference and words
    public void DisplayScripture()
    {
        Console.Clear();

        //optionally display the reference
        Console.WriteLine(_reference.ScriptReference());

        //display each word in the scripture taking into accout whether it is hidden or not
        Console.WriteLine(string.Join(" ", _words.Select(w => w.Text)));
    }

    //the ScriptureText method returns the full display text but without clearing the screen
    public string ScriptureText()
    {
        return $"{_reference.ScriptReference()} {string.Join(" ", _words.Select(w => w.Text))}";
    }

    //check if all te words in the scriptures are hidden
    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden);
    }

    //check if the scripture is completely hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden);
    }

}