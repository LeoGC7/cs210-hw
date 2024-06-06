public class Event
{
    protected string _title;
    private string _description;
    protected DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToString("MM/dd/yyyy")}\nTime: {_time}\nAddress: {_address.GetAddress()}";
    }

    public string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Event Type: Generic\nTitle: {_title}\nDate: {_date.ToString("MM/dd/yyyy")}";
    }
}
