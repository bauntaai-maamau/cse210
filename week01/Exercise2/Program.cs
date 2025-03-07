using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int percent = int.Parse(valueFromUser);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percent >= 97 && percent <= 100 && letter == "A")
            letter += "+";
        else if (percent >= 90 && percent < 93 && letter == "A")
            letter += "-";
        else if (percent >= 87 && percent < 90 && letter == "B")
            letter += "+";
        else if (percent >= 80 && percent < 83 && letter == "B")
            letter += "-";
        else if (percent >= 77 && percent < 80 && letter == "C")
            letter += "+";
        else if (percent >= 70 && percent < 73 && letter == "C")
            letter += "-";
        else if (percent >= 77 && percent < 70 && letter == "D")
            letter += "+";
        else if (percent >= 60 && percent < 63 && letter == "D")
            letter += "-";

        Console.WriteLine($"Your letter grade is {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed. ");
        }
        else
        {
            Console.WriteLine("Better luck next time. ");
        }

    }
}