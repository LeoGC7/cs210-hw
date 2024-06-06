using System.Diagnostics;

public class Goal
{   
    // objects
    protected string _shortName;
    protected string _description;
    public int _points;

    // constructor
    protected Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // methods
    
    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual void RecordEvent()
    {
    }

    public virtual string GetDetailsString()
    {
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }

    public string GetGoalName()
    {
        return $"{_shortName}";
    }
}