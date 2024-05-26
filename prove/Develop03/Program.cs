using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            SimulateConsoleClear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit" || scripture.AreAllWordsHidden())
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.WriteLine("Program ended.");
    }

    static void SimulateConsoleClear()
    {
        for (int i = 0; i < 40; i++) // 40 lines to simulate clearing the console
        {
            Console.WriteLine();
        }
    }
}