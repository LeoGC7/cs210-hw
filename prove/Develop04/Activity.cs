using System.ComponentModel;

public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void StartMessage()
    {
        Console.WriteLine($"\nHello! Welcome to the {_name} Activity");
        Console.WriteLine($"{_description}");
    }

    public int ActivityDuration()
    {
        Console.Write("\nEnter the time you want the activity to last (in seconds): ");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine();

        return duration;
    }

    public void DisplayLoading(int seconds)
    {
        
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds;  i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }

    public void EndMessage()
    {
        Console.WriteLine("\nYou've done a great job!");
    }

}