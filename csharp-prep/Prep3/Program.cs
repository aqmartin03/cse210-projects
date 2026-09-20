using System;

class Program
{
    static void Main(string[] args)
    {
        Random numberGenerator = new Random();
        int magic = numberGenerator.Next(1, 101);
        int guess = -1;
        int guessAmount = 0;
        while (magic != guess)
        {
            Console.Write("What is your guess? ");
            string userInput2 = Console.ReadLine();
            guessAmount ++;
            guess = int.Parse(userInput2);
            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed It!");
                Console.WriteLine($"You had a total of {guessAmount} guesses.");
            }
        }
    }
}