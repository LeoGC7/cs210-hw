using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goal = new GoalManager();

        goal.Start();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nChoose an option");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display player information");
            Console.WriteLine("7. Quit");

            int userOption;

            while (!int.TryParse(Console.ReadLine(), out userOption) || userOption < 1 || userOption > 7)
            {
                Console.WriteLine("Invalid Option. Please choose again.");
            }

            switch (userOption)
            {
                case 1:
                    goal.CreateGoal();
                    break;
                case 2:
                    goal.ListGoalDetails();
                    break;
                case 3:
                    goal.SaveGoals();
                    break;
                case 4:
                    goal.LoadGoals();
                    break;
                case 5:
                    goal.RecordEvent();
                    break;
                case 6:
                    goal.DisplayPlayerInfo();
                    break;
                case 7:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}