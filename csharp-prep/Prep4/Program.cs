using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int userNum = -1;
        int sum = 0;
        while (userNum != 0)
        {
            Console.Write("Enter number: ");
            string num = Console.ReadLine();
            userNum = int.Parse(num);
            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }
        // Calculate the Sum
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        // Calculate the Average
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        // Calculate the Max
        int max = 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
        // Stretch: Find the smallest positive number
        int smallPos = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (number < smallPos)
                {
                    smallPos = number;
                }
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallPos}");
    }
}