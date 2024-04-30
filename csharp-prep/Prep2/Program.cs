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
        }
        
        else if (gradeNumber >= 80)
        {
            Console.WriteLine("Your grade is B");
        }

        else if (gradeNumber >= 70)
        {
            Console.WriteLine("Your grade is C");
        }

        else if (gradeNumber >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }
    }
}