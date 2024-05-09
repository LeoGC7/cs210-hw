using System;

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
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Answer: {entry._entryText}");
            Console.WriteLine();
        }

    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }
}