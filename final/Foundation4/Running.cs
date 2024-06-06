public class Running : Activity
{
    private double _distance;

    public Running(string name, DateTime date, int duration, double distance) 
        : base(name, date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _durationInMinutes * 60;
    }

    public override double GetPace()
    {
        return _durationInMinutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {_distance} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}