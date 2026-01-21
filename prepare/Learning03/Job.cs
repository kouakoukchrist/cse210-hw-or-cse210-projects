using System;

public class Job
{
    private string _company = "";
    private string _jobTitle = "";
    private int _startYear = 0;
    private int endYear = 0;

    public Job()
{
    
}
public void ShowInformation()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{endYear}");
    }

}

