using System;

public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int point)
        : base(title, description, point)
    {
    }

    public override int AddProgress()
    {
        return _point;
    }

    public override string DisplayGoal()
    {
        return $"[ ] {_title} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_title}|{_description}|{_point}|False";
    }
}