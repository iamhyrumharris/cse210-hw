public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        return _laps * 50 / 1000.0 * 0.62;
    }

    public override double Speed()
    {
        return Distance() / _lengthInMinutes * 60;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_lengthInMinutes} min) - Distance: {Distance():F2} miles, Speed: {Speed():F2} mph, Pace: {Pace():F2} min/mile";
    }
}