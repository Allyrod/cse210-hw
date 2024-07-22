public class Reception : Event
{
    private string _rsvpEmail;

    // Constructor for Reception
    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string StandardDetails()
    {
        return $"{base.StandardDetails()}";
    }

    public override string FullDetails()
    {
        return $"Type : Reception - Full Description\n{StandardDetails()}\nRSVP Email: {_rsvpEmail}";
    }

    public override string ShortDescription()
    {
        return $"Type : Reception - Short Description\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}