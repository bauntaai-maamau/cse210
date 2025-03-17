using System;

public class Entry
{
    public string _date;
    public string _prompts;
    public string _entryText;

    public Entry(string date, string prompts, string entryText)
    {
        _date = date;
        _prompts = prompts;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompts} ");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }
}