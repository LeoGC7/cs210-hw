using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("Running", new DateTime(2024, 11, 3), 30, 3.0),
            new StationaryBicycles("Stationary Bicycles", new DateTime(2024, 11, 4), 45, 25.0),
            new Swimming("Swimming ",new DateTime(2024, 11, 5), 60, 20),
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}