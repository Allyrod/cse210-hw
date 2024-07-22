public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    // Constructor for Lecture
    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string StandardDetails()
    {
        return $"{base.StandardDetails()}";
    }

    public override string FullDetails()
    {
        return $"Type : Lecture - Full Description\n{StandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public override string ShortDescription()
    {
        return $"Type : Lecture - Short Description\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}