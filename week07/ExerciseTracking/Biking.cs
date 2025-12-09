public class Biking : Activity
{
    private double _speedInMph;

    public Biking(string date, int length, double speedInMph) : base(date, length)
    {
        _speedInMph = speedInMph;
    }

    public override double Distance()
    {
        return _speedInMph * (_lengthInMinutes / 60.0);
    }

    public override double Speed()
    {
        return _speedInMph;
    }

    public override double Pace()
    {
        return 60 / _speedInMph;
    }

    public override string GetSummary()
    {
        return $"{_date} Biking ({_lengthInMinutes} min) - Distance: {Distance():F2} miles, Speed: {Speed():F2} mph, Pace: {Pace():F2} min/mile";
    }
}