public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public  string GetFullDetailsRec()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }

    public string GetShortDescriptionRec()
    {
        return $"Event Type: Reception\nTitle: {_title}\nDate: {_date.ToString("MM/dd/yyyy")}";
    }
}
