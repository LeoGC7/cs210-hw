using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

    static string PromptUserName()
        {
            Console.Write("Type your name: ");
            string name = Console.ReadLine();

            return name;
        }

    static int PromptUserNumber()
        {
            Console.Write("Enter a number: ");
            string userEntry = Console.ReadLine();
            int number = int.Parse(userEntry);

            return number;
        }

    static int SquareNumber(int userNumber)
        {
            int squareNumber = userNumber * userNumber;

            return squareNumber;
        }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}