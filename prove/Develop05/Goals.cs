using System;

public abstract 
class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _completed;

    public string Name
        {
            get { return _name; }
            set { _name = value; } // Use 'value' keyword to assign the incoming value
        }

    public string Description
        {
            get { return _description; }
            set { _description = value; } // Use 'value' keyword to assign the incoming value
        }

    public int Points
        {
            get { return _points; }
            set { _points = value; } // Use 'value' keyword to assign the incoming value
        }

    public bool Completed
        {
            get { return _completed; }
            set { _completed = value; } // Use 'value' keyword to assign the incoming value
        }

    public Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
            _completed = false; 
        }

    public virtual void QuestionsAboutGoal()
        {
            Console.Write("What is the name of your goal? ");
            _name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            _description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            _points = int.Parse(Console.ReadLine());
        }

    public virtual string GetStatusString() // its been used when listing the goals in program
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

    public abstract void RecordCompletion(); // abstract method that will be override in the derived classes
}
