public class MathAssignment : Assignment
{
    //objects
    private string _textbook;
    private string _problems;

    //constructors
    public MathAssignment(string name, string topic, string textbook, string problems) : base(name, topic)
    {
        _textbook = textbook;
        _problems = problems;
    }

    //methods
    public string GetMathSummary()
    {
        return $"{_name} - {_topic}";
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbook} Problems {_problems}";
    }
}
