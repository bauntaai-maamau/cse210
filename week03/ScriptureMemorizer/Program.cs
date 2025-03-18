using System;

class Program
{
    static void Main(string[] args)
    {
        
        var reference = new Reference("John", 3, 16);
        var scripture = new Scripture(reference, "For God so love the world that He gave his only begotten Son.");

        while (true)
        {
            //display the scripture
            scripture.DisplayScripture();

            //prompt the user
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            //exit the program if the user type 'quit'
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            //hide random word if 'Enter' is pressed
            if (userInput == "")
            {
                bool wordToHide = scripture.HideRandomWord();
                if (!wordToHide || scripture.AllWordsHidden())
                {
                    Console.WriteLine("All words are now hidden. The program will exit.");
                    break;
                }
            }
        }

    }
}