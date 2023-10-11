using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction unmodified = new Fraction(1);
        Console.WriteLine(unmodified.GetFractionString());
        Console.WriteLine(unmodified.GetDecimalValue());

        Fraction first = new Fraction(5);
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());

        Fraction second = new Fraction(3, 4);
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());

        Fraction third = new Fraction(1, 3);
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());
    }
}