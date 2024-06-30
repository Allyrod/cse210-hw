public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    

    public override void QuestionsAboutGoal() // pull the list of questions from the base class 
    {
        base.QuestionsAboutGoal();
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
        Program.AddPoints(Points); 
    }
}