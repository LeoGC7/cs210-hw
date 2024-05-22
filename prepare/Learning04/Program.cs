using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");

        Console.WriteLine(assignment.GetSummary() + "\n");

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "9-19");

        Console.WriteLine(mathAssignment.GetMathSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList()+ "\n");

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(writingAssignment.GetWritingSummary());
        Console.WriteLine(writingAssignment.GetWritingInfo());
    }
}