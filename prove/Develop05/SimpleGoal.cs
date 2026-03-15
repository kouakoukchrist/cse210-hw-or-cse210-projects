using System;

public class SimpleGoal : Goal
{
    public SimpleGoal (string title, string description, int point) :
     base(title, description, point){
    }

public override int AddProgress()
    {
        _isComplete = true;
        return _point;
    }


public override string GetStringRepresentation()
{
    return $"SimpleGoal:{_title}|{_description}|{_point}|{_isComplete}";
}
}