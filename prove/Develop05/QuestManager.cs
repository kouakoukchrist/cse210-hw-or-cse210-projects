using System;
using System.Collections.Generic;
using System.IO;

public class QuestManager
{
    protected List<Goal> _goals;
    protected int _score;
    protected string _filename = "goals.txt";

    public QuestManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void SaveGoals(string filename)
    {
        _filename = filename;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine($"Goals saved in {filename}");
    }

    public void LoadGoals(string filename)
    {    _filename = filename;
    
        if (!File.Exists(filename))
        {
            Console.WriteLine("No save file found!");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');

            string goalType = parts[0];
            string details = parts[1];
            string[] detailParts = details.Split('|');

            if (goalType == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(
                    detailParts[0],
                    detailParts[1],
                    int.Parse(detailParts[2])
                );

                goal.SetIsComplete(bool.Parse(detailParts[3]));
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(
                    detailParts[0],
                    detailParts[1],
                    int.Parse(detailParts[2])
                );

                goal.SetIsComplete(bool.Parse(detailParts[3]));
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(
                    int.Parse(detailParts[4]),
                    int.Parse(detailParts[5]),
                    detailParts[0],
                    detailParts[1],
                    int.Parse(detailParts[2])
                );

                goal.SetIsComplete(bool.Parse(detailParts[3]));
                goal.SetCompletionAmount(int.Parse(detailParts[6]));

                _goals.Add(goal);
            }
        }
    }

    public void CreateNewGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                SimpleGoal goal = new SimpleGoal("", "", 0);
                goal.InputGoal();
                _goals.Add(goal);
                break;

            case "2":
                EternalGoal eternal = new EternalGoal("", "", 0);
                eternal.InputGoal();
                _goals.Add(eternal);
                break;

            case "3":
                ChecklistGoal check = new ChecklistGoal(0, 0, "", "", 0);
                check.InputGoal();
                _goals.Add(check);
                break;
        }
    }

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].DisplayGoal()}");
        }

        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void RecordEvent()
    {
        ListGoals();

        Console.WriteLine();
        Console.WriteLine("Which goal did you accomplish?");

        int index = int.Parse(Console.ReadLine()) - 1;

        _score += _goals[index].AddProgress();

        SaveGoals(_filename);

    if (_goals[index].GetIsComplete())
{
    Console.WriteLine("Congratulations! You completed the goal!");
}
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {_score} points.");
    }
}