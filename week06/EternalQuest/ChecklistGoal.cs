public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isCompleted;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;    
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
        
            if (_amountCompleted >= _target)
            {
                _isCompleted = true;
                return _points + _bonus;
            }
            return _points;
        }
        Console.WriteLine("This goal is already complete.");
        return 0;
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetDetailsString()
    {
        string check = IsComplete() ? "[x]" : "[ ]";
        return $"{check} {_description} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }

}