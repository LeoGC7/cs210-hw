using System;

class Program
{
   static void Main(string[] args)
    {
        Address address1 = new Address("123 Random St", "City 1", "CA", "USA");
        Address address2 = new Address("456 Random St", "City 2", "NY", "USA");
        Address address3 = new Address("789 Random St", "City 3", "ID", "USA");

        Lecture lecture = new Lecture("Cool Title", "Awesome description", new DateTime(2024, 6, 1), new TimeSpan(3, 0, 0), address1, "Someone Cool", 50);

        Reception reception = new Reception("Cool Title 2", "Awesome description 2", new DateTime(2024, 6, 15), new TimeSpan(5, 0, 0), address2, "rsvp@cool.email.com");

        OutdoorGathering gathering = new OutdoorGathering("Cool Title 3", "Awesome description 3", new DateTime(2024, 7, 4), new TimeSpan(7, 0, 0), address3, "Sunny");

        List<Event> events = new List<Event> { lecture, reception, gathering };

        foreach (Event ev in events)
        {
            Console.WriteLine("===========");
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();

            if (ev is Lecture)
            {
                Lecture lec = ev as Lecture;
                Console.WriteLine("Full Details (Lecture):");
                Console.WriteLine(lec.GetFullDetailsLec());
                Console.WriteLine();

                Console.WriteLine("Short Description (Lecture):");
                Console.WriteLine(lec.GetShortDescriptionLec());
                Console.WriteLine();
            }

            else if (ev is Reception)
            {
                Reception rec = ev as Reception;
                Console.WriteLine("Full Details (Reception):");
                Console.WriteLine(rec.GetFullDetailsRec());
                Console.WriteLine();

                Console.WriteLine("Short Description (Reception):");
                Console.WriteLine(rec.GetShortDescriptionRec());
                Console.WriteLine();
            }
            
            else if (ev is OutdoorGathering)
            {
                OutdoorGathering outg = ev as OutdoorGathering;
                Console.WriteLine("Full Details (Outdoor Gathering):");
                Console.WriteLine(outg.GetFullDetailsOut());
                Console.WriteLine();

                Console.WriteLine("Short Description (Outdoor Gathering):");
                Console.WriteLine(outg.GetShortDescriptionOut());
                Console.WriteLine();
            }
        }
    }
}