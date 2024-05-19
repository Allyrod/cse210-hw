using System;
using System.IO; // Include the System.IO namespace for file operations

class Journal
{
    static void Main(string[] args)
    {
        bool continueLoop = true;
        while (continueLoop)
        {
            // Display menu options
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            // Read user's choice
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();

            // Ask the user what action they want to perform
            if (userInput == "1")
            {
                // Ask a random question from PromptGenerator
                string randomQuestion = PromptGenerator.PickRandomQuestion();
                Console.WriteLine(randomQuestion);
                // Read the user's answer
                Console.Write("");
                string userAnswer = Console.ReadLine();
                // Store the user's answer
                Entry.UserAnswers.Add(userAnswer);
                
            }
            else if (userInput == "2")
            {
                // Display all user answers
                Entry.DisplayAllEntries();
            }
                // Load file using the method LoadJournalFromFile
            else if (userInput == "3")
            {
                LoadJournalFromFile();
            }
                // Save the file using method SaveJournalToFile
            else if (userInput == "4")
            {
                Console.WriteLine("");
                SaveJournalToFile();
            }
                // User quit
            else if (userInput == "5")
            {
                Console.WriteLine("");
                continueLoop = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
            }
        }
    }

    static void SaveJournalToFile()
    {
        // Prompt the user for the filename
        Console.Write("Enter the filename to save: ");
        string filename = Console.ReadLine();

        try
        {
            // Open the file for writing
            using (StreamWriter writer = new StreamWriter(filename))
            {
                // Write each journal entry to the file
                foreach (string entry in Entry.UserAnswers)
                {
                    writer.WriteLine(entry);
                }
            }
            Console.WriteLine($"Journal saved to {filename}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    static void LoadJournalFromFile()
    {
        // Prompt the user for the filename
        Console.Write("Enter the filename to load: ");
        string filename = Console.ReadLine();

        try
        {
            // Open the file for reading
            using (StreamReader reader = new StreamReader(filename))
            {
                // Clear existing journal entries
                Entry.UserAnswers.Clear();

                // Read each line from the file and add it to the journal entries
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Entry.UserAnswers.Add(line);
                }
            }
            Console.WriteLine($"Journal loaded from {filename}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}
