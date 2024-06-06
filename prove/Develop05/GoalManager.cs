using System.IO;
using System.Text;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private string _playerName;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.Write("Please enter your name: ");
        _playerName = Console.ReadLine();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player name: {_playerName}");
        Console.WriteLine($"Score: {_score}");        
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            goal.GetGoalName();
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\n1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal\n");
        Console.Write("Choose the goal type: ");
        string goalType = Console.ReadLine();

        if (int.Parse(goalType) == 1)
        {
            Console.Write("\nEnter the goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter the number of points for this goal: ");
            int points = int.Parse(Console.ReadLine());
            bool isComplete = false;

            SimpleGoal newSimpleGoal = new SimpleGoal(name, description, points, isComplete);

            _goals.Add(newSimpleGoal);
            
        }

        else if (int.Parse(goalType) == 2)
        {
            Console.Write("\nEnter the goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter the number of points for this goal: ");
            int points = int.Parse(Console.ReadLine());

            EternalGoal newEternalGoal = new EternalGoal(name, description, points);

            _goals.Add(newEternalGoal);
        }

        else if (int.Parse(goalType) == 3)
        {
            Console.Write("\nEnter the goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter the number of points for this goal: ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("Enter the goal target: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter the bonus points when the goal is completed: ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal newChecklistGoal = new ChecklistGoal(name, description, points, target, bonus, 0);

            _goals.Add(newChecklistGoal);
        }

        else
        {
            Console.WriteLine("Invalid Answer");
        }
    }

    public void RecordEvent()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalName()}");
        }

        Console.Write("\nSelect the goal you want to record and event for: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += _goals[index]._points;
            Console.WriteLine("\n Event recorded successfully");
        }

        else
        {
            Console.WriteLine("\nInvalid Goal Number");
        }
    }

    public void SaveGoals()
    {   
        Console.Write("\n Enter the file name: ");
        string fileName = Console.ReadLine() + ".txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully");
    }

    public void LoadGoals()
    {
        Console.Write("\n Enter the file name to be loaded: ");
        string fileName = Console.ReadLine() + ".txt";

        if (File.Exists(fileName))
        {
            _goals.Clear();

            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 4) //SimpleGoal
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    bool isComplete = bool.Parse(parts[3]);

                    SimpleGoal newSimplesGoal = new SimpleGoal(name, description, points, isComplete);
                    _goals.Add(newSimplesGoal);
                }

                else if (parts.Length == 3) //EternalGoal
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);

                    EternalGoal newEternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(newEternalGoal);
                }

                else if (parts.Length == 6) //ChecklistGoal
                {
                    string name = parts[0];
                    string description = parts[1];
                    int amountCompleted = int.Parse(parts[2]);
                    int target = int.Parse(parts[3]);
                    int points = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);

                    ChecklistGoal newChecklistGoal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                    _goals.Add(newChecklistGoal);
                }

                else
                {
                    Console.WriteLine("File not found");
                }
            }
        }

    }
}