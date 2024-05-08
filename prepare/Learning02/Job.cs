using System;

public class Job {
    public string _company;
    public string _jobTitle;
    public nint _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}