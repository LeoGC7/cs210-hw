using System.Reflection.Metadata;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"\nYou've received {_points} points");
    }

    public override bool IsComplete()
    {   
        if (_isComplete == true)
        {
            Console.WriteLine($"Congratulations! You've completed the {_shortName} goal!");
            return true;
        }

        else
        {
            return false;
        }        
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_isComplete}";
    }

    public override string GetDetailsString()
    {
        if (_isComplete == true)
        {
            return $"[X] {_shortName}, {_description} - Status: Completed";
        }

        else
        {
            return $"[ ] {_shortName}, {_description} - Status: In Progress - Points to earn: {_points}";
        };
    }
}