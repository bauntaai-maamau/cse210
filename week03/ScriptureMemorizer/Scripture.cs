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

    public void DisplayScripture()
    {
        Console.Clear();
        //Console.WriteLine(_reference.GetReference());
        Console.WriteLine(string.Join(" ", _words.Select(w => w.Text)));
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden);
    }
}