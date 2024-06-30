using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static List<Goal> goals = new List<Goal>();
    private static int totalPoints = 0;

    public static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();

            ShowMainMenu();
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void ShowMainMenu()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
        }

    static void CreateGoal()
        {
            Console.WriteLine("Which type of goal would you like to create?");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Checklist Goal");
            Console.WriteLine(" 3. Eternal Goal");
            Console.Write("Select a goal type to create: ");
            string subOption = Console.ReadLine();

            Goal newGoal = null;
            switch (subOption)
            {
                case "1":
                    newGoal = new SimpleGoal("Default Name", "Default Description", 0);
                    break;
                case "2":
                    newGoal = new ChecklistGoal("Default Name", "Default Description", 0, 0, 0);
                    break;
                case "3":
                    newGoal = new EternalGoal("Default Name", "Default Description", 0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            if (newGoal != null)
            {
                newGoal.QuestionsAboutGoal(); // Polymorphism invokes the correct overridden method
                goals.Add(newGoal);
                Console.WriteLine();
            }
        }

    static void ListGoals()
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].GetStatusString()}");
                
            }
        }

    static void RecordEvent()
        {
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals available to record.");
                return;
            }

            Console.WriteLine("The goals are:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].Name}");
            }

            Console.Write("Which goal did you accomplish? ");
            int selectedGoalIndex = int.Parse(Console.ReadLine());

            Goal selectedGoal = goals[selectedGoalIndex - 1];
            selectedGoal.RecordCompletion();
            totalPoints += selectedGoal.Points;
            Console.WriteLine($"Event recorded for goal '{selectedGoal.Name}'. You earned {selectedGoal.Points} points.");
            Console.WriteLine($"You now have {totalPoints} points.");
            
            
        }

    public static void SaveGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Goal goal in goals)
                {
                    string goalType = goal.GetType().Name;
                    string serializedData = SerializeGoal(goal);
                    string line = $"{goalType}:{serializedData}";
                    outputFile.WriteLine(line);
                }
            }

            Console.WriteLine($"Goals successfully saved to '{filename}'.");
        }

    private static string SerializeGoal(Goal goal)
        {
            if (goal is SimpleGoal simpleGoal)
            {
                return $"{simpleGoal.Name},{simpleGoal.Description},{simpleGoal.Points}";
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                return $"{checklistGoal.Name},{checklistGoal.Description},{checklistGoal.Points},{checklistGoal.TimesToBeCompleted},{checklistGoal.BonusForCompletion}";
            }
            else if (goal is EternalGoal eternalGoal)
            {
                return $"{eternalGoal.Name},{eternalGoal.Description},{eternalGoal.Points}";
            }
            throw new ArgumentException($"Unsupported goal type: {goal.GetType().Name}");
        }

    public static void LoadGoals()
        {
            Console.Write("Enter the filename to load goals from: ");
            string filename = Console.ReadLine();

            goals.Clear();

            try
            {
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length != 2)
                    {
                        Console.WriteLine($"Skipping invalid line: {line}");
                        continue;
                    }

                    string goalType = parts[0];
                    string serializedData = parts[1];
                    Goal goal = DeserializeGoal(goalType, serializedData);

                    if (goal != null)
                    {
                        goals.Add(goal);
                    }
                    else
                    {
                        Console.WriteLine($"Failed to deserialize goal from line: {line}");
                    }
                }

                Console.WriteLine($"Goals successfully loaded from '{filename}'.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File '{filename}' not found. No goals loaded.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading goals from '{filename}': {ex.Message}");
            }
        }

    private static Goal DeserializeGoal(string goalType, string serializedData)
        {
            string[] dataParts = serializedData.Split(',');

            switch (goalType)
            {
                case "SimpleGoal":
                    if (dataParts.Length == 3)
                    {
                        string name = dataParts[0];
                        string description = dataParts[1];
                        int points = int.Parse(dataParts[2]);
                        return new SimpleGoal(name, description, points);
                    }
                    break;
                case "ChecklistGoal":
                    if (dataParts.Length == 5)
                    {
                        string name = dataParts[0];
                        string description = dataParts[1];
                        int points = int.Parse(dataParts[2]);
                        int timesToBeCompleted = int.Parse(dataParts[3]);
                        int bonusForCompletion = int.Parse(dataParts[4]);
                        return new ChecklistGoal(name, description, points, timesToBeCompleted, bonusForCompletion);
                    }
                    break;
                case "EternalGoal":
                    if (dataParts.Length == 3)
                    {
                        string name = dataParts[0];
                        string description = dataParts[1];
                        int points = int.Parse(dataParts[2]);
                        return new EternalGoal(name, description, points);
                    }
                    break;
                default:
                    Console.WriteLine($"Unsupported goal type: {goalType}");
                    break;
            }

            return null;
        }

    public static void AddPoints(int points)
        {
            totalPoints += points;
        }
}