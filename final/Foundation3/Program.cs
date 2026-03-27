using System;

class Program
{
    static void Main(string[] args)
    {
      Address A1 = new Address("625 South Fourth Avenue","Pocatello","Idaho","USA");
      Address A2 = new Address("1365 South Fourth Avenue","Rexburg","Idaho","USA");
      Address A3 = new Address("7893 East Fourth Avenue","Seattle","Washington","USA");

    Lecture L1 = new Lecture("Dr. John Smith", 100, "Introduction to Western History", "A beginner friendly lecture on the French Revolution", "March 25, 2026", "6:00 PM", A1);

    Reception R1 = new Reception("rsvp@technightusa.com", "Annual Tech Networking Night", "A networking event for tech professionals", "April 10, 2026", "7:00 PM", A2);

    OutdoorGathering O1  = new OutdoorGathering("Sunny with a high of 75°F", "Summer Music Festival", "A fun outdoor music festival for all ages", "June 15, 2026", "12:00 PM", A3);


    List<Event> events = new List<Event>();
    events.Add(L1);
    events.Add(R1);
    events.Add(O1);


    foreach (Event ev  in events)
{
         Console.WriteLine(ev.GetStandardDetails());

         Console.WriteLine();   

         Console.WriteLine(ev.GetShortDescription());   

         Console.WriteLine();   
     
         Console.WriteLine( " Event Full Details:\n " + ev.GetFullDetails());

         Console.WriteLine();   
}

    }

}
