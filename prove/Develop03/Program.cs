using System;
using System.Net.Quic;
using System.Text.RegularExpressions;

//For additional creativity I added a test to check if the user memorized the scripture by typing it

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("Ether",12,27);
        string text = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
        
        Scripture scripture = new Scripture(reference, text);

        Console.WriteLine(reference.ReferenceGetDisplayText() + " " + scripture.ScriptureGetDisplayText());

        Console.WriteLine();


        Console.WriteLine("Press 'enter' to hide more words, type 'c' to challenge yourself or type 'quit' to leave");
        string userAnswer = Console.ReadLine();

        while (userAnswer == "")
        {
            Console.Clear();
            scripture.HideRandomWord(3);
            Console.WriteLine(reference.ReferenceGetDisplayText() + " " + scripture.ScriptureGetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press 'enter' to hide more words, type 'c' to challenge yourself or type 'quit' to leave");
            userAnswer = Console.ReadLine();
        }

        if (userAnswer.ToLower() == "quit")
        {
            Console.WriteLine("Goodbye!");
        }
        
        else if (userAnswer.ToLower() == "c")
        {
            Console.Clear();
            Console.WriteLine("Type the scripture: ");
            string challenge = Console.ReadLine();

            
            if (CleanText(challenge).ToLower() == CleanText(text).ToLower())
            {
                Console.WriteLine("Congratulations! You memorized the scripture!");
            }

            else
            {
                Console.WriteLine("\nYou missed something, try again.");
                Console.WriteLine("Type the scripture or 'giveup': ");
                challenge = Console.ReadLine();

                if (challenge.ToLower() == "giveup")
                {
                    Console.WriteLine("Goodbye!");
                }

                else if (CleanText(challenge).ToLower() == CleanText(text).ToLower())
                {
                    Console.WriteLine("\nCongratulations! You memorized the scripture!");
                }
            }
        }

    }

    static string CleanText(string input)
    {
        string cleaned = Regex.Replace(input, @"[^\w\s]", "");
        return cleaned;
    }

}
