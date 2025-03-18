using System;

class Program
{
    static void Main(string[] args)
    {
        //define reference and scripture
        Reference reference = new Reference("John", 3, 16);
        string ScriptureText = "For God so love the world that He gave his only begotten Son.";

        //create a new scripture with the reference and text
        Scripture scripture = new Scripture(reference, ScriptureText);

        //display the scritpure and prompt the user
        while (true)
        {
            //display the current scripture
            scripture.DisplayScripture();

            //check if all the words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Exiting the Program.\n");
                break;
            }

            //prompt the user for the next action
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
                scripture.HideMultipleWords(2);
                //bool wordToHide = scripture.HideRandomWord();
                //if (!wordToHide || scripture.AllWordsHidden())
                //{
                //    Console.WriteLine("All words are now hidden. The program will exit.");
                //    break;
                //}
            }
        }

    }
}