using System;

class Program
{
    static void Main(string[] args)

    {
        // Example prompt and entry text
        string prompt = "What is your favorite book?";
        string entry = "My favorite book is '1984' by George Orwell.";

        // Create an Entry object
        Entry newEntry = new Entry(prompt, entry);

        // Display the entry
        newEntry.Display();
    }
}