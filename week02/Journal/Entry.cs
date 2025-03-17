using System;

public class Entry
{
    public string _date;
    public string _prompts;
    public string _entryText;

    public Entry(string prompts, string entryText)
    {
        _date = DateTime.Now.ToString("dd/MM/yyyy");
        _prompts = prompts;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompts} {_entryText}");
    }
}