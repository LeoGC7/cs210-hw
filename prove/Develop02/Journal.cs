using System;
using System.IO;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


public class Journal {
    // objects
    public List<Entry> _entries;

    // constructor
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // methods
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry userInput in _entries)
        {
            Console.WriteLine($"Date: {userInput._date}");
            Console.WriteLine($"Prompt: {userInput._promptText}");
            Console.WriteLine($"Answer: {userInput._entryText}\n");
        }

    }

    public void SaveToFile()
    {                  
        string fileName = "C:/Users/Desktop/Desktop/" + Console.ReadLine() + ".txt";

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {   
                foreach(Entry entry in _entries)
                {
                    outputFile.WriteLine($"Date: {entry._date}");
                    outputFile.WriteLine($"Prompt: {entry._promptText}");
                    outputFile.WriteLine($"Answer: {entry._entryText}\n");

                    Console.WriteLine($"Date: {entry._date}");
                    Console.WriteLine($"Prompt: {entry._promptText}");
                    Console.WriteLine($"Answer: {entry._entryText}\n");
                }
            }

            Console.WriteLine($"Journal entries saved to '{fileName}' successfully.");           

    }


    public void LoadFromFile()
    {
        string filename = Console.ReadLine() + ".txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}