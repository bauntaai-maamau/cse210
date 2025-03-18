using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to week 3 project!!");

        Reference b1 = new Reference("John", 14, 15, 12);
        Console.WriteLine(b1.SingleVerseString());
        Console.WriteLine(b1.MultipleVersesString());
        Console.WriteLine();

    }
}