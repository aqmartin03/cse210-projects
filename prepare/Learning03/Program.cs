using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fr1 = new Fraction();
        Random rand = new Random();
        for (int i = 0; i < 20; i++)
        {
            int top = rand.Next(1, 11);
            int bottom = rand.Next(1, 11);
            fr1.SetTop(top);
            fr1.SetBottom(top);
            Console.Write($"Fraction: {i + 1}: ");
            Console.Write($"string: {fr1.GetFractionString()}");
            Console.WriteLine($" Number: {fr1.GetDecimalValue()}");
        }
    }
}