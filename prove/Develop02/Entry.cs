using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public DateTime _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
         _promptText = promptGenerator.GetRandomPrompt();
         _date = DateTime.Now;
    }

    public void AnEntry()
    {
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
        
    }

    public void Display()
    {

    }
    
} 