using System;

public class ChecklistGoal : Goal
{
    protected int _completionTotal;
    protected int _completionAmount;
    protected int _bonusScore;

    public ChecklistGoal(int completionTotal, int bonusScore, string title, string description, int point)
        : base(title, description, point)
    {
        _completionTotal = completionTotal;
        _bonusScore = bonusScore;
        _completionAmount = 0;
    }

    public override void InputGoal()
    {
        base.InputGoal();

        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        string totalInput = Console.ReadLine();
        int total;

        while (!int.TryParse(totalInput, out total))
        {
            Console.WriteLine("Please enter a valid number.");
            totalInput = Console.ReadLine();
        }

        _completionTotal = total;

        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        string bonusInput = Console.ReadLine();
        int bonus;

        while (!int.TryParse(bonusInput, out bonus))
        {
            Console.WriteLine("Please enter a valid number.");
            bonusInput = Console.ReadLine();
        }

        _bonusScore = bonus;
    }

    public override string DisplayGoal()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_title} ({_description}) -- Completed {_completionAmount}/{_completionTotal} times";
    }

    public override int AddProgress()
    {
        if (_completionAmount >= _completionTotal)
        {
            return 0;
        }

        _completionAmount++;

        if (_completionAmount == _completionTotal)
        {
            _isComplete = true;
            return _point + _bonusScore;
        }

        return _point;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_title}|{_description}|{_point}|{_isComplete}|{_completionTotal}|{_bonusScore}|{_completionAmount}";
    }

    public void SetCompletionAmount(int completionAmount)
    {
        _completionAmount = completionAmount;
    }
}