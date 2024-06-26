    public class Reflecting : Activity
    {
        private List<string> _prompts;   
        private List<string> _questions;
        
        public Reflecting() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
            _questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            _prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };
        }

        public void ReflectingActivity()
        {
            StartMessage();

            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"--- {prompt} ----");
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue");

            // Wait for the user to press Enter
            Console.ReadLine();
            
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
            Console.Write("You may begin in: ");
            base.Countdown(3);
            Console.Clear();
            
            // Adding delay between each question
            int interval = base.GetDuration() / 3;
            for (int i = 0; i < interval; i++)
            {
                string question = _questions[random.Next(_questions.Count)];
                Console.WriteLine();
                Console.Write(question + " ");
                base.Animation(5); // Adding a delay after displaying each question
                Console.WriteLine(); // Move to the next line after the animation
            }

            EndMessage();
        }
    }