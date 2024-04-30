using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your score? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);

        if (gradeNumber >= 90)
        {
            Console.WriteLine("Your grade is A");
            Console.WriteLine("You passed in the class! Congratulations!");
        }
        
        else if (gradeNumber >= 80)
        {
            Console.WriteLine("Your grade is B");
            Console.WriteLine("You passed in the class! Congratulations!");
        }

        else if (gradeNumber >= 70)
        {
            Console.WriteLine("Your grade is C");
            Console.WriteLine("You passed in the class! Congratulations!");
        }

        else if (gradeNumber >= 60)
        {
            Console.WriteLine("Your grade is D");
            Console.WriteLine("Sorry, you failed in the class. Try harder next time!");
        }
        else
        {
            Console.WriteLine("Your grade is F");
            Console.WriteLine("Sorry, you failed in the class. Try harder next time!");
        }
    }
}