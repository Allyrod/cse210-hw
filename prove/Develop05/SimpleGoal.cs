public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    

    public override void QuestionsAboutGoal()
    {
        base.QuestionsAboutGoal(); // pull the list of questions from the base class 
    }

    public override string GetStatusString() // its been used when listing the goals in program
    {
        if (Completed)
        {
            return $"[ X ] {Name} ({Description})";
        }
        else
        {
            return $"[   ] {Name} ({Description})";
        }
    }

    public override void RecordCompletion() // add points for each time the goal is completed
    {
        Completed = true;
        Program.AddPoints(Points); // Add points
    } 
}
