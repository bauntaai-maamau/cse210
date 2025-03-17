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

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName, append: true))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"Date: {entry._date}");
                writer.WriteLine($"Prompt: {entry._prompts}");
                writer.WriteLine($"Entry: {entry._entryText}");
                writer.WriteLine();
            }
        }
        Console.WriteLine("Entries save to file.");
    }

    public void LoadFromFile()
    {
        Console.Write("Please enter the file name you would like to load from: ");
        String filename = Console.ReadLine();
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string dateString = reader.ReadLine();
                    string content = reader.ReadLine();
                    Entry entry = new Entry(dateString, content);
                    entries.Add(entry);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading entries from :filename: {e.Message}");
        }
    }

}

