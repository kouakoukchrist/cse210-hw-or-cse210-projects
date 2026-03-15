using System;

// I have added in Goals.cs and and If statement in Quest Manager to get the current state of the goal.
// To verify whether or not if th was completed, and returned a congratitulation message for the user. 
class Program
{
    static void Main(string[] args)
    {
        QuestManager questManager = new QuestManager();

        string choice = "";

        while (choice != "6")
        {
            Console.Clear();

            questManager.DisplayScore();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    questManager.CreateNewGoal();
                    break;

                case "2":
                    questManager.ListGoals();
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string saveFile = Console.ReadLine();
                    questManager.SaveGoals(saveFile);
                    break;

                case "4":
                    Console.Write("What is the filename? ");
                    string loadFile = Console.ReadLine();
                    questManager.LoadGoals(loadFile);
                    Console.WriteLine("Goals loaded!");
                    questManager.ListGoals();
                    break;

                case "5":
                    questManager.RecordEvent();
                    break;
            }

            if (choice != "6")
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}