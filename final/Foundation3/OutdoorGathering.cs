public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetFullDetailsOut()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }

    public string GetShortDescriptionOut()
    {
        return $"Event Type: Outdoor Gathering\nTitle: {_title}\nDate: {_date.ToString("MM/dd/yyyy")}";
    }
}
