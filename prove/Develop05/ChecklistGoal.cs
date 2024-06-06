public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    public int _bonus;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountedCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountedCompleted;
        _isComplete = _amountCompleted >= _target;
    }


    public override void RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("Congratulations! You've completed this Goal!");
            return;
        }

        _amountCompleted++;
        Console.WriteLine($"\nCongratulations! You've completed this goal {_amountCompleted} times! Current progress: {_amountCompleted}/{_target}");

        if (_amountCompleted >= _target)
        {   
            _isComplete = true;
            _points += _bonus;
            Console.WriteLine($"Congratulations! You've completed your goal!");
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_amountCompleted},{_target},{_points},{_bonus}";
    }

        public override string GetDetailsString()
    {
        if (_amountCompleted < _target)
        {
            return $"[ ] {_shortName}, {_description} - Status: In Progress {_amountCompleted}/{_target} - Points to earn: {_points} + {_bonus} when finished";
        }

        else
        {
            return $"[X] {_shortName}, {_description} - Status: Completed {_amountCompleted}/{_target}";
        }
    }

}