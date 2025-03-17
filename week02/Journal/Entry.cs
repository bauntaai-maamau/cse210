using System;

public class Entry
{
    public string _date;
    public string _prompts;
    public string _entryText;

    public Entry(string _prompts, string _entryText)
    {
        _date = DateTime.Now.ToString("dd/MM/yyyy");
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompts} {_entryText}");
    }
}