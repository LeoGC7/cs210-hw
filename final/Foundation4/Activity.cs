public class Activity
{
    protected string _name;
    protected DateTime _date;
    protected int _durationInMinutes;

    public Activity(string name, DateTime date, int duration)
    {
        _name = name;
        _date = date;
        _durationInMinutes = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToString("MM/dd/yyyy")} {_name} ({_durationInMinutes} min)";
    }
}