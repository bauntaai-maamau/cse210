using System;
using System.Transactions;

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
        Console.WriteLine($"{_prompts}");
        Console.Write("> ");
        string content = Console.ReadLine();
        string _date = DateTime.Now.ToString("dd/MM/yyyy");
        Entry newEntry = new Entry(_date, _prompts, content);
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

        using (StreamWriter writer = new StreamWriter(fileName, append: false))
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
        string filename = Console.ReadLine();

        try
        {

            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    // Read Date, Prompt, and Content (Entry Text)
                    string dateString = reader.ReadLine();
                    string promptString = reader.ReadLine();
                    string content = reader.ReadLine();

                    // Skip empty line after each entry if present
                    reader.ReadLine();

                    // Ensure all lines are valid
                    if (dateString != null && promptString != null && content != null)
                    {
                        // Strip the "Date:", "Prompt:", and "Entry:" prefixes
                        dateString = dateString.Replace("Date: ", "").Trim();
                        promptString = promptString.Replace("Prompt: ", "").Trim();
                        content = content.Replace("Entry: ", "").Trim();

                        // Create a new Entry object and add it to the list
                        Entry entry = new Entry(dateString, promptString, content);
                        entries.Add(entry);
                    }
                }
            }
        }
        catch
        {
            Console.WriteLine("Error loading entries: File not found. Please check the filename.");
        }
    }
}
