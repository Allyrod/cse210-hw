using System;
using System.Collections.Generic;

public class Entry
{
    // List to store user answers
    public static List<string> UserAnswers = new List<string>();

    // Method to display all entries with date
    public static void DisplayAllEntries()
    {
        Console.WriteLine();
        for (int i = 0; i < UserAnswers.Count; i++)
        {
            // Get the corresponding prompt
            string prompt = PromptGenerator.prompts[i % PromptGenerator.prompts.Count];
            // Get the current date
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy");
            // Display date, prompt, and user answer
            Console.WriteLine($"Date: {currentDate} - Prompt: {prompt} - {UserAnswers[i]}");
        }
    }
}
