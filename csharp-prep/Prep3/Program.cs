using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,101);

        int userGuessInt =  -1;

        while (userGuessInt != randomNumber)
        {
            Console.WriteLine("What's the magic number?");
            userGuessInt = int.Parse(Console.ReadLine());
            
            if (userGuessInt > randomNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (userGuessInt < randomNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed the number!");
            }
        }
    }
}