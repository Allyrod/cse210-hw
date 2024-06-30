public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _timesToBeCompleted;
    private int _bonusForCompletion;

    public int TimesCompleted
        {
            get { return _timesCompleted; }
            set { _timesCompleted = value; }
        }

    public int TimesToBeCompleted
        {
            get { return _timesToBeCompleted; }
            set { _timesToBeCompleted = value; }
        }

    public int BonusForCompletion
        {
            get { return _bonusForCompletion; }
            set { _bonusForCompletion = value; }
        }

    public ChecklistGoal(string name, string description, int points, int TimesToBeCompleted, int BonusForCompletion) : base(name, description, points)
       {
            _timesCompleted = 0;
            _timesToBeCompleted = TimesToBeCompleted;
            _bonusForCompletion = 0;
        }

    public override string GetStatusString() // pull the list of questions from the base class 
        {
            if (TimesCompleted >= TimesToBeCompleted)
            {
                return $"[ X ] {Name} ({Description}) -- Completed {TimesCompleted}/{TimesToBeCompleted} times";
            }
            else
            {
                return $"[   ] {Name} ({Description}) -- Completed {TimesCompleted}/{TimesToBeCompleted} times";
            }
        }

    
    public void MarkAsCompleted()
        {
            _timesCompleted++;
        }

    // Optional: Method to handle additional questions about the goal
    public override void QuestionsAboutGoal() // pull the list of questions from the base class 
        {
            base.QuestionsAboutGoal();

            Console.Write("How many times does this goal need to be accomplished? ");
            _timesToBeCompleted = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            _bonusForCompletion = int.Parse(Console.ReadLine());
        }

    public override void RecordCompletion() // add points for each time the goal is completed, it will keep adding until TimesCompleted >= TimesToBeCompleted 
        {
            if (TimesCompleted < TimesToBeCompleted)
            {
                TimesCompleted++;
                if (TimesCompleted >= TimesToBeCompleted)
                {
                    Completed = true;
                    Console.WriteLine($"Congratulations! You have earned {_bonusForCompletion} bonus points!");
                    Program.AddPoints(_bonusForCompletion); // Add bonus points
                }
            }
        }    
}
