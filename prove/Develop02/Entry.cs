using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    // objects
    public string _date;
    public string _promptText;
    public string _entryText;

    // constructor
    public Entry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
         _promptText = promptGenerator.GetRandomPrompt();
         _date = DateTime.Now.ToString("MM/dd/yyyy");
    }

    // methods
    public void AnEntry()
    {
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
        
    }

    public void Display()
    {

    }
    
} 