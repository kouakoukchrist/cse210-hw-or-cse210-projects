// If Statement  && While


Console.WriteLine("What is the magic number");
int guess = 0;

while (guess != 6)
{
    Console.Write("What is your guess: ");
    guess = int.Parse(Console.ReadLine());

    if (guess == 6)
    {
        Console.WriteLine("You guessed it");
    }
    else if (guess > 6)
    {
        Console.WriteLine("Lower");
    }
    else
    {
        Console.WriteLine("Higher");
    }
}


