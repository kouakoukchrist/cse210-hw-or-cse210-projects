   
 using System;
    
  class Program
{
    static void Main(string[] args)
    {
      DisplayWelcome();

      string name = PromptUserName();
      Console.WriteLine($"Welcome, {name}");

      int number = PromptUserNumber();
      Console.WriteLine($"My favorite number is {number}");

      int  birthYear;
      PromptUserBirthYear(out birthYear);
      Console.WriteLine($"You were born in {birthYear}");
      
      int squaredNumber = SquareNumber(number);
      Console.WriteLine($"Your number squared is {squaredNumber}");

      DisplayResult(userName, squaredNumber, birthYear);


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to The Program");
    }
    static string PromptUserName()
    {
       Console.Write("What is Your Name");
       string name = Console.ReadLine();
       return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
    Console.Write("What year were you born? ");
    birthYear = int.Parse(Console.ReadLine());
    }

   static int SquareNumber(int number)
{
    return number * number;
}
    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2025 - birthYear} years old this year.");
    }
    
}