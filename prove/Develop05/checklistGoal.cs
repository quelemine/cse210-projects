class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string DisplayStatus()
    {
        return $"[{_currentCount}/{_targetCount}] ";
    }

    public override string SaveGoal()
    {
        return $"Checklist|{base.SaveGoal()}|{_targetCount}|{_currentCount}|{_bonusPoints}";
    }

    public override void LoadGoal(string[] data)
    {
        base.LoadGoal(data);
        _targetCount = int.Parse(data[3]);
        _currentCount = int.Parse(data[4]);
        _bonusPoints = int.Parse(data[5]);
    }
}
