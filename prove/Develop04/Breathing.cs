public class Breathing : Activity
{
    private List<string> _breathingInstructions;  // Declare field at class level

    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {   
        _breathingInstructions = new List<string>  // Initialize the field in the constructor
        { 
            "Breathe in...", 
            "Breathe out..." 
        };
    }

    public void BreathingActivity()
    {
        StartMessage();

        int totalDuration = base.GetDuration(); // Get total duration of the activity
        int breatheInDuration = 4;
        int breatheOutDuration = 6;

        // Calculate how many full cycles fit into the total duration
        int fullCycles = totalDuration / (breatheInDuration + breatheOutDuration);

        // Calculate remaining time after full cycles
        int remainingTime = totalDuration % (breatheInDuration + breatheOutDuration);

        for (int i = 0; i < fullCycles; i++)
        {
            // Display "Breathe in..." and countdown
            Console.WriteLine();
            Console.Write(_breathingInstructions[0] + " ");
            Countdown(breatheInDuration);
            Console.WriteLine();

            // Display "Breathe out..." and countdown
            Console.Write(_breathingInstructions[1] + " ");
            Countdown(breatheOutDuration);
            Console.WriteLine();
        }

        // If there's remaining time, perform part of the cycle
        if (remainingTime > 0)
        {
            // Determine which instruction to display based on remainingTime
            string currentInstruction = remainingTime >= breatheInDuration ? _breathingInstructions[0] : _breathingInstructions[1];
            int countdownDuration = remainingTime >= breatheInDuration ? breatheInDuration : breatheOutDuration;

            // Display the current instruction with countdown
            Console.Write(currentInstruction + " ");
            Countdown(countdownDuration);
            Console.WriteLine();
        }

        EndMessage();
    }

    
}
