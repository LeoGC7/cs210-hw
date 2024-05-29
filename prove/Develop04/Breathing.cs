using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

public class Breathing : Activity
{
    public Breathing() 
           : base("Breathing", "This activity will help you calm down by breathing techniques. Please, follow carefully the isntructions and try to relax", 0)
    {
    }

    public void Breath()
    {
        Console.Write("Breathe in...");
        Countdown(4);
        Console.WriteLine();
        Console.Write("Breathe out...");
        Countdown(6);
        Console.WriteLine();
    }

    public void Run()
    {
        StartMessage();
        int userInputDuration = ActivityDuration();
        DisplayLoading(2);

        if (userInputDuration < 10)
        {
            Console.WriteLine("Please, enter a value above 10 seconds");
        }

        else if (userInputDuration >= 10)
        {
            Console.Write("Prepare yourself, we'll begin in ");
            Countdown(3);
            Console.WriteLine();
            int rest = userInputDuration % 10;
            int times = userInputDuration / 10;

            if (rest >= 4)
            {
                Console.Write("Breathe in...");
                Countdown(rest/2);
                Console.WriteLine();
                Console.Write("Breathe out...");
                Countdown(rest/2);
                Console.WriteLine();

                for (int i = times; i > 0; i--)
                {
                    Breath();
                }
            }

            else
            {   
                for (int i = times; i > 0; i--)
                {
                    Breath();
                }
            }
        }
        EndMessage();
    }
}