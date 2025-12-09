public abstract class Activity
{
    protected string _date;
    protected int _lengthInMinutes;


    public Activity(string date, int length)
    {
        _date = date;
        _lengthInMinutes = length;
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public abstract string GetSummary();

}