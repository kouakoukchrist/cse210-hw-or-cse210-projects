// I added a search feature that allows the user to search journal entries
// by keyword and display only the matching entries.


using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit");

            Console.Write("What would you like to do? ");

            string userInput = Console.ReadLine();
            choice = int.Parse(userInput);

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    string promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(promptText);
                    Console.Write("Write your journal entry: ");
                    string entryText = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();

                    Entry newEntry = new Entry(date, promptText, entryText);
                    journal.AddEntry(newEntry);
                    break;

                 case 2:
                    journal.DisplayAll();
                    break;

                 case 3:
                 Console.Write("Enter filename to save: ");
                 string saveFile = Console.ReadLine();
                 journal.SaveToFile(saveFile);
                 Console.WriteLine("Saved!");
                 break;

                 case 4:
                 Console.Write("Enter filename to load: ");
                 string loadFile = Console.ReadLine();
                 journal.LoadFromFile(loadFile);
                 Console.WriteLine("Loaded!");
                 break;  
                  
                  case 5:
                  Console.Write("Enter a word to search for: ");
                  string keyword = Console.ReadLine();
                  journal.Search(keyword);
                  break;

            }

                Console.WriteLine();
        }
    }
}
