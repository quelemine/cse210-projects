class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // No completion state for eternal goals
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string DisplayStatus()
    {
        return "[∞] ";
    }

    public override string SaveGoal()
    {
        return $"Eternal|{base.SaveGoal()}";
    }

    public override void LoadGoal(string[] data)
    {
        base.LoadGoal(data);
    }
}
