public class PromptGenerator {
    // objects
    public List<string> _prompts;

    // constructor
    public PromptGenerator ()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person you interacted with today?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "If you had one thing you could do over today, what would it be?",
            "What was the most unexpected thing that happened today?",
            "Describe a moment that made you laugh today.",
            "What was the most challenging part of your day?",
            "How did you show kindness or compassion to someone today?",
            "What are you grateful for today?",
            "What new thing did you learn today?",
            "How did you take care of yourself today?",
            "Describe a goal or achievement from today.",
            "What activity or hobby brought you joy today?",
            "What is one thing you would like to improve upon tomorrow?",
            "What made you proud of yourself today?",
            "Describe a moment when you felt inspired today.",
            "How did you overcome a challenge today?",
            "What was a small act of kindness you witnessed today?",
            "What song or music did you enjoy listening to today?",
            "What book, article, or podcast resonated with you today?",
            "Describe a dream or aspiration you have for the future.",
            "Reflect on a mistake you made today and what you learned from it.",
            "What are you looking forward to tomorrow?",
            "Describe a moment of peace or tranquility you experienced today.",
            "How did you contribute positively to your community or environment today?",
            "What's a funny or interesting conversation you had today?",
            "Reflect on a memorable meal or food experience today.",
            "What is one thing you can do to improve your well-being?",
            "Describe an achievement or progress toward a goal today.",
            "How did you express gratitude or appreciation today?",
            "What was a moment of serendipity or unexpected joy?",
            "How did you connect with nature or the outdoors today?",
            "Reflect on a time when you felt confident and empowered.",
            "What was the highlight of your day and why?"
        };
        }

    // methods
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}