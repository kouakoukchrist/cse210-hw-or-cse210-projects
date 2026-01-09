// See https://aka.ms/new-console-template for more information


using System;

class Program
{
static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

Console.Write("What is your first name?");
string firstname = Console.ReadLine();

Console.Write("What is your last name?");
string lastname = Console.ReadLine();

Console.WriteLine($"Your name is {firstname},{firstname} {lastname}.");
    }
}