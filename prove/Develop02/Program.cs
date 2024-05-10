using System;
using System.ComponentModel;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Select one of the following options:\n");

        bool keepRunning = true;
        while (keepRunning)
        {
            Console.WriteLine("1. Write | 2. Display | 3. Load | 4. Save | 5. Quit \n");
            Console.Write("What would you like to do? ");
            int userAnswer = int.Parse(Console.ReadLine());

            if (userAnswer == 1)
            {
                Entry userEntry = new Entry();
                userEntry.AnEntry();
                journal.AddEntry(userEntry);
            }

            if (userAnswer == 2)
            {
                journal.DisplayAll();
            }

            if (userAnswer == 3)
            {
                Console.WriteLine("Enter the file name you want to load: ");
                journal.LoadFromFile();
            }

            if (userAnswer == 4)
            {
                Console.WriteLine("Enter the file name: ");
                journal.SaveToFile();
                
            }

            if (userAnswer == 5)
            {
                keepRunning = false;
            }


        }

  
    }
}