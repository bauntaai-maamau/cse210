using System;

public class Entry
{
    public string _date;
    public string _promtText;
    public string _entryText;

    public Entry(string _promtText, string _entryText)
    {
        _date = DateTime.Now.ToString("yyyyy-MM-dd");
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promtText} {_entryText}");
    }
}