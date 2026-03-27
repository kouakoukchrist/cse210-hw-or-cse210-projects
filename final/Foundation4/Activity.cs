using System;

public class Activity
{
    private string _date;
    private double _duration;
public Activity(string date, double duration)
    {
        _date = date;
        _duration= duration;
    }

public string GetDate()
    {
        return _date;
    }

public  double GetDuration()
    {
        return _duration;
    }

public virtual double GetDistance()
    {
        return 0;
    }
public virtual double GetSpeed()
    {
        return 0;
    }

public virtual double GetPace()
    {
        return 0;
    }

public virtual string GetSummary()
    {
        return $" {_date}, {GetType().Name} ({_duration} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per km";
    }

}