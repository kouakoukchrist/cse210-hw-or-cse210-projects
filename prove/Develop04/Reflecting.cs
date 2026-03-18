public class Reflecting : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<string> _unusedQuestions;

    public Reflecting() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.") 
    {
        _unusedQuestions = new List<string>(_questions);
    }

    public void Run()
    {
        StartMessage();
        Random rnd = new Random();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n --- {_prompts[rnd.Next(_prompts.Count)]} --- \n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Write("Now ponder on each of the following questions as they relate to this experience: ");
        ShowCountdown(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            if (_unusedQuestions.Count == 0) _unusedQuestions = new List<string>(_questions);
            
            int index = rnd.Next(_unusedQuestions.Count);
            Console.Write($"\n> {_unusedQuestions[index]} ");
            _unusedQuestions.RemoveAt(index);
            
            ShowSpinner(8); 
        }
        EndMessage();
    }
}