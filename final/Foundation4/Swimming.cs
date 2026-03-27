using System;
public class Swimming : Activity
{
    private int _laps;
public Swimming( int laps, string date, double duration) : base( date,  duration)
    {
        _laps = laps;
    }

public int GetLaps()
    {
        return _laps;
    }

public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0 * 0.62;
    }
public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }
public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}