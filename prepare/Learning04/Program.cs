using System;

class Program
{
    static async Task Main(string[] args)

    {
         Assigment a1 = new Assigment ("Christ Kouakou", "Geology");
         Console.WriteLine(a1.GetSummary());

         MathAssignment a2 = new MathAssignment("Jess Gaye", "X thing", "22", "239");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Yasmine Ali", "Egyptian Law", "Who buiilt up the Pyramids.");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
    
}