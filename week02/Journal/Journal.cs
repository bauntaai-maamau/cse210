using System;

public class Journal
{
    public List<Entry> entries;
    public PromptGenerator promptGenerator;
    public Journal()
    {
        entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }

    //Adds a new entry to the journal from user input
    public void AddEntry()
    {
        string _prompts = promptGenerator.GenerateRandomPrompt();
        Console.WriteLine($"Today's Prompt: {_prompts}");
        Console.Write("> ");
        string content = Console.ReadLine();

        Entry newEntry = new Entry(_prompts, content);

        entries.Add(newEntry);

        newEntry.Display();
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }

}

