using System.Reflection.Metadata;

public class Listing : Activity
{
    private List<string> _prompts;
    private string _userAnswer;
    private List<string> _userAnswersList;
    public Listing()
           : base ("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", 0)
        {
        _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

        _userAnswersList = new List<string> {};
        }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine(randomPrompt);
    }

    public void Run()
    {
        StartMessage();
        int userInputDuration = ActivityDuration();
        DisplayLoading(2);

        int numberOfPrompts = userInputDuration /30;

        if (userInputDuration < 30)
        {
            Console.WriteLine("Please, enter a value above 30 seconds");
        }

        else if (userInputDuration >= 30)
        {   
            for (int i = numberOfPrompts; i > 0; i--)
            {
                GetRandomPrompt();
                GetUserAnswer(userInputDuration);
                Console.WriteLine("\nThe total amount of items listed were " + TotalItemsListed());

            }
        }
        EndMessage(); 
    }

    public void GetUserAnswer(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Console.WriteLine("You have 30 seconds to write as many answers as you can");

        while (DateTime.Now < endTime)
        {
            _userAnswer = Console.ReadLine();
            _userAnswersList.Add(_userAnswer);
        }
    }

    public int TotalItemsListed()
    {
        int items = _userAnswersList.Count;

        return items;
    }
}