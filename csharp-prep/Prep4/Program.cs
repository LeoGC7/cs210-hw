using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a list
        List<int> numbers;
        numbers = new List<int>();

        // Defining the variable
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // While loop to keep asking for a new number until the enter value is 0
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");

            // Asking for a user input
            string userEntry = Console.ReadLine();

            // All users input are strings, so we have to make them integers
            userNumber = int.Parse(userEntry);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;

        // for each number in the list "numbers" the program will add it to the sum variable
        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // setting the max number as the first user input
        int max = numbers[0];

        // for each number in the list "numbers" the program will compare if it's bigger than the
        // first number inputed, and if it is, it will became the new max
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}