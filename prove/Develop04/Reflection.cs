using Microsoft.VisualBasic;

public class Reflection : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflection()
           : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
        {
            _prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            _questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?",
                "Did this experience change your perspective on anything?",
                "How did this experience contribute to your personal growth?",
                "What skills did you develop as a result of this experience?",
                "What did you find most challenging about this experience?",
            };
        }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine(randomPrompt);
    }

    public void GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        string randomQuestion = _questions[randomIndex];
        Console.WriteLine(randomQuestion);
    }

    public void Run()
    {
        StartMessage();
        int userInputDuration = ActivityDuration();
        DisplayLoading(2);

        int numberOfQuestions = userInputDuration / 20;
        int rest = userInputDuration % 20;

        if (userInputDuration < 20)
        {
            Console.WriteLine("Please, enter a value above 20 seconds");
        }

        else if (userInputDuration >= 20)
        {   
            GetRandomPrompt();
            DisplayLoading(15);

            for (int i = numberOfQuestions; i > 0; i--)
            {
                GetRandomQuestion();
                DisplayLoading(20);
            }
        }
        EndMessage(); 
    }

}