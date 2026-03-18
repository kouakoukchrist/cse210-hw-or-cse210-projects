class Program
{
    static void Main(string[] args)
    {
        
        // 1. I added logic in Reflecting activity to ensure random questions
        //  do not repeat until all have been used.
        // 2. I added input validation for activity duration to prevent program crashes.

        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new Breathing().Run();
                    break;
                case "2":
                    new Reflecting().Run();
                    break;
                case "3":
                    new Listing().Run();
                    break;
            }
        }
        Console.WriteLine("\nGoodbye!");
    }
}