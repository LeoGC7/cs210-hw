using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1._fname = "Leo";
        p1._lname = "Correa";
        p1._age = 22;

        Person p2 = new Person();
        p2._fname = "Calvin";
        p2._lname = "Viado";
        p2._age = 23;

        List<Person> people = new List<Person>();

        people.Add(p1);
        people.Add(p2);

        foreach (Person p in people)
        {
            Console.WriteLine(p._fname);
        }

        SaveToFile(people);
    }

    public static void SaveToFile(List<Person> people)
    {
        string fileName = "C:/Users/Desktop/Desktop/people.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Person p in people)
            {
                outputFile.WriteLine(p._fname);

            }
        }
    }
}