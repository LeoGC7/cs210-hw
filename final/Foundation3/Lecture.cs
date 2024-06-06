public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDetailsLec()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public string GetShortDescriptionLec()
    {
        return $"Event Type: Lecture\nTitle: {_title}\nDate: {_date.ToString("MM/dd/yyyy")}";
    }
}
