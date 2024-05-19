using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public static List<string> prompts = new List<string>
    {
        "What are you grateful for today?",
        "What was the most challenging part of your day?",
        "Describe a memorable moment from today.",
        "What did you learn today?",
        "How did you feel today?"        
    };

    public static string PickRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(prompts.Count);
        return prompts[index];
    }


}