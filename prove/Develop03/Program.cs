using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Matthieu", 12, 30);

        string text = "lui qui n'est pas avec moi est contre moi, et celui qui n'assemble pas avec moi disperse.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine($"\nWords left: {scripture.GetRemainingWordCount()}");

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
