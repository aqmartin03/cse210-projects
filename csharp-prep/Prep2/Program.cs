using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string letter = "";
        string sign = "";
        if (percentage >= 90)
        {
            if (percentage < 93)
            {
                sign = "-";
            }
            letter = "A";
        }
        else if (percentage >= 80)
        {
            if (percentage >= 87)
            {
                sign = "+";
            }
            else if (percentage < 83)
            {
                sign = "-";
            }
            letter = "B";
        }
        else if (percentage >= 70)
        {
            if (percentage >= 77)
            {
                sign = "+";
            }
            else if (percentage < 73)
            {
                sign = "-";
            }
            letter = "C";
        }
        else if (percentage >- 60)
        {
            if (percentage >= 67)
            {
                sign = "+";
            }
            else if (percentage < 63)
            {
                sign = "-";
            }
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        string together = letter + sign;
        Console.WriteLine($"You got a {together}.");
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass the class. Better luck next time.");
        }
    }
}