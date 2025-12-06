using System.ComponentModel;
using System.Runtime.InteropServices;

public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {}

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isCompleted}";
    }

}