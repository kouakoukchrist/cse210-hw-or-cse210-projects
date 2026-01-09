using System;
class Program
{
static void Main(string[] args)
    {
        
 Console.Write("What is your grade: ");
 int grade = int.Parse(Console.ReadLine());
if (grade >= 90)
{
    Console.WriteLine("you have an A");
}
else if (grade >= 80)
{
    Console.WriteLine("you have a B");
}
else if (grade >= 70)
{
    Console.WriteLine("you have a C");
}
else if (grade >= 60)
{
    Console.WriteLine("you have  D");
}
else
{
    Console.WriteLine("you have a F");
}
    }
}