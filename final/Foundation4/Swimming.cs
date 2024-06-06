public class Swimming : Activity
{
    private int _laps;

    public Swimming(string name, DateTime date, int duration, int laps) 
        : base(name, date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _durationInMinutes * 60;
    }

    public override double GetPace()
    {
        return _durationInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}