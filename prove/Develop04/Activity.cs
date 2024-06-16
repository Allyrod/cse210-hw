using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    private List<string> _animationStrings;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
        _animationStrings = new List<string>
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\"
        };

    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0; // Initialize to 0; will be set later by user input
        _animationStrings = new List<string>
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\"
        };
               
        
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public List<string> GetAnimationStrings()
    {
        return _animationStrings;
    }

        public void StartMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        Animation(3);
    }

    public void EndMessage()
    {   
        Console.WriteLine();
        Console.WriteLine("Well done");
        Animation(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        Animation(3);
        Console.Clear();
    }

    public void Animation(int seconds)
    {
        int i = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {

            string s = _animationStrings[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");

            i++;

            if (i >= _animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void Countdown(int duration)
    {
        for (int countdown = duration; countdown > 0; countdown--)
            {
                Console.Write(countdown + " ");
                Thread.Sleep(1000); // Wait 1 second for each countdown step

                // Use backspace character to overwrite the previous countdown number
                Console.Write("\b\b"); // Move cursor back twice to overwrite the countdown number
            }

            // Clear the last countdown number and the space after it
            Console.Write("\b  \b"); // Move cursor back once, clear two characters, and move back again
    }
}
