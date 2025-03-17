using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string randomPromt = promptGenerator.GenerateRandomPrompt();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                //Adds new entry
                case "1":
                    journal.AddEntry();
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    journal.LoadFromFile();
                    break;

                case "4":
                    Console.Write("Enter the file name to save: ");
                    string fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);  
                    break;


                case "5":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid selection, please enter a number 1-5.");
                    break;

            }
        }
    }
}