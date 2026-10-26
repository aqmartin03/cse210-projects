using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment hmwk1 = new Assignment("Avery Martin", "Programming with Classes");
        Console.WriteLine(hmwk1.GetSummary());

        MathAssignment hmwk2 = new MathAssignment("Avery", "Calculus", "1.3.5", "1-10");
        Console.WriteLine(hmwk2.GetSummary());
        Console.WriteLine(hmwk2.GetHomeworkList());

        WritingAssignment hmwk3 = new WritingAssignment("Avery", "Math", "The Basics of Calculus");
        Console.WriteLine(hmwk3.GetSummary());
        Console.WriteLine(hmwk3.GetWritingInformation());
    }
}