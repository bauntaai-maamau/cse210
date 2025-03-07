using System;

class Program
{
    static void Main(string[] args)
    {
        string response;

        do
        {
            //Console.Write("What is the magic number? ");
            //int magicNumber = int.Parse(Console.ReadLine());

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int guess = -1;
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write("Guess a number between 1 & 100. What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses. ");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            response = Console.ReadLine().ToLower();

        }

        while (response == "yes");
        Console.WriteLine("Thanks for playing! See you next time.");

    }
}