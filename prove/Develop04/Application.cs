using System;

public class Application
{
    public void Run()
    {
        DisplayMenu();
    }

    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine(" 1. Breathing Activity");
            Console.WriteLine(" 2. Reflecting Activity");
            Console.WriteLine(" 3. Listing Activity");
            Console.WriteLine(" 4. Exit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    Breathing breathing = new Breathing();
                    breathing.BreathingActivity();
                    break;
                case 2:
                    Reflecting reflecting = new Reflecting();
                    reflecting.ReflectingActivity();
                    break;
                case 3:
                    Listing listing = new Listing();
                    listing.ListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
