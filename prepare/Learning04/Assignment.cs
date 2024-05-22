public class Assignment
{
    //objects
    protected string _name;
    protected string _topic;

    //constructors
    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    //methods
    public string GetSummary()
    {
        return $"{_topic} by {_name}";
    }
}