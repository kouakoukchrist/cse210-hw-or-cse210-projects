using System;

public class Running : Activity
{
    private double _distance;

public Running( double distance, string date, double duration) : base( date,  duration)
    {
        _distance = distance;
    }
public override double GetDistance()
    {
        return _distance;
    }

public override double GetSpeed()
    {
        return (_distance/GetDuration()) * 60;
    }

public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}