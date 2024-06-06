public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"\nCongratulations! You've received {_points} points");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"- {_shortName},{_description},{_points}";
    }

        public override string GetDetailsString()
    {
        return $"- {_shortName}, {_description} - Status: In Progress - Points to earn: {_points}";
    }
}