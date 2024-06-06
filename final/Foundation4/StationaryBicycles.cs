public class StationaryBicycles : Activity
{
    private double _speed;

    public StationaryBicycles(string name, DateTime date, int duration, double speed) 
        : base(name, date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed; 
    }

    public override double GetDistance()
    {
        return _speed * _durationInMinutes/60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }

}