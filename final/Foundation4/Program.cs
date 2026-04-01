using System;

class Program
{
    static void Main(string[] args)
    {
       Running R1 = new Running (3.0, "26 Mar 2026",30);
       Running R2 = new Running (5.0, "27 Mar 2026",20);


       Swimming S1 = new Swimming (3, "26 Mar 2026",15);
       Swimming S2 = new Swimming (5, "29 Mar 2026",30);

       Cycling C1 = new Cycling (30, "1 April 2026",60);
       Cycling C2 = new Cycling (60, "2 April 2026",30);

    List<Activity> Act = new List<Activity>();

    Act.Add(R1);
    Act.Add(R2);

    Act.Add(S1);
    Act.Add(S2);

    Act.Add(C1);
    Act.Add(C2);

    foreach(Activity activity in Act)
        {
        Console.WriteLine(activity.GetSummary());
        Console.WriteLine("------------------");
        

        }
    }
}