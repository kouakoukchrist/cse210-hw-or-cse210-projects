using System;

public class Goal
{
    protected int _point;
    protected string _description;
    protected string _title;
    protected bool _isComplete;

    public Goal(string title, string description, int point)
    {
        _title = title;
        _description = description;
        _point = point;
        _isComplete = false;
    }

    public virtual void InputGoal()
    {
        Console.WriteLine("What is the name of your goal?");
        _title = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        _description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal?");

        string input = Console.ReadLine();
        int value;

        while (!int.TryParse(input, out value))
        {
            Console.WriteLine("Please enter a valid number.");
            input = Console.ReadLine();
        }

        _point = value;
    }

    public virtual string DisplayGoal()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_title} ({_description})";
    }

    public virtual int AddProgress()
    {
        _isComplete = true;
        return _point;
    }

    public virtual string GetStringRepresentation()
    {
        return $"SimpleGoal:{_title}|{_description}|{_point}|{_isComplete}";
    }
public bool GetIsComplete()
{
    return _isComplete;
}
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
}