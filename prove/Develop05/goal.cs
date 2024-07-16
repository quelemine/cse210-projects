using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    private string _name;
    private string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string DisplayStatus();

    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual string SaveGoal()
    {
        return $"{_name}|{_description}|{_points}";
    }

    public virtual void LoadGoal(string[] data)
    {
        _name = data[0];
        _description = data[1];
        _points = int.Parse(data[2]);
    }
}
