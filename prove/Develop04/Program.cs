using System;

class Program
{
    static void Main(string[] args)
    {
        Activity loading = new Activity("loading", "loading", 0);
        Reflection reflection = new Reflection();
        Breathing breathing = new Breathing();
        Listing listing = new Listing();

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1- Breathing Activity");
        Console.WriteLine("2- Reflection Activity");
        Console.WriteLine("3- Listing Activity");

        int userChoice = int.Parse(Console.ReadLine());

        if (userChoice == 1)
        {
            loading.DisplayLoading(2);
            breathing.Run();
        }

        else if (userChoice == 2)
        {
            loading.DisplayLoading(2);
            reflection.Run();
        }

        else if (userChoice == 3)
        {
            loading.DisplayLoading(2);
            listing.Run();
        }
    }
}