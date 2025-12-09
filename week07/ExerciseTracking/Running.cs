public class Running : Activity
{
    private double _distanceInMiles;

    public Running(string date, int length, double distanceInMiles) : base(date, length)
    {
        _distanceInMiles = distanceInMiles;
    }

    public override double Distance()
    {
        return _distanceInMiles;
    }

    public override double Speed()
    {
        return _distanceInMiles / _lengthInMinutes * 60;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_lengthInMinutes} min) - Distance: {Distance():F2} miles, Speed: {Speed():F2} mph, Pace: {Pace():F2} min/mile";
    }
}