public class Listing : Activity
{
    private List<string> _prompts;

    public Listing()  : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void ListingActivity()
    {
        StartMessage();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        
        // Randomly select a prompt
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"--- {prompt} ----");
     
        Console.Write("You may begin in: ");
        Countdown(3);
        Console.WriteLine(); // Move to the next line after the countdown

        DateTime startTime = DateTime.Now;
        int itemCount = 0;

        while ((DateTime.Now - startTime).TotalSeconds < base.GetDuration())
            {
                Console.Write("> ");
                string item = Console.ReadLine();
                itemCount++;
            }

        Console.WriteLine($"You listed {itemCount} items.");
        Console.WriteLine();
    
        EndMessage(); // Ensure EndMessage does not clear the console
    }
}
