public class WritingAssignment : Assignment
{
    //objects
    private string _title;

    //constructors
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    //methods
    public string GetWritingSummary()
    {
        return $"{_name} - {_topic}";
    }

    public string GetWritingInfo()
    {
        return $"{_title} by {_name}";
    }
}