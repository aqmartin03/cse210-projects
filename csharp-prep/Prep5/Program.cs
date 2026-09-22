using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int birthYear;
        PromptUserBirthYear(out birthYear);
        int squared = SquareNumber(num);
        DisplayResult(name, squared, birthYear);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int num = int.Parse(number);
        return num;
    }

    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int favNum)
    {
        int square = favNum * favNum;
        return square;
    }

    static void DisplayResult(string userName, int squaredNum, int birthYear)
    {
        int age = 2026 - birthYear;
        Console.WriteLine($"{userName}, the square of your number is {squaredNum}");
        Console.WriteLine($"{userName}, you will turn {age} this year.");
    }
}