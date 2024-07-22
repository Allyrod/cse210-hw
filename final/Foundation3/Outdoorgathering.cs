public class OutdoorGathering : Event
{
    private string _weatherForecast;

    // Constructor for OutdoorGathering
    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string StandardDetails()
    {
        return $"{base.StandardDetails()}\nWeather Forecast: {_weatherForecast}";
    }

    public override string FullDetails()
    {
        return $"Type : Outdoor Gathering - Full Description\n{StandardDetails()}";
    }

    public override string ShortDescription()
    {
        return $"Type : Outdoor Gathering - Short Description\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}