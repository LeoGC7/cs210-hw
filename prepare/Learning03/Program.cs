using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Console.WriteLine(frac1.GetFraction());
        Console.WriteLine(frac1.GetDecimal());

        Fraction frac2 = new Fraction(6);
        Console.WriteLine(frac2.GetFraction());
        Console.WriteLine(frac2.GetDecimal());


        Fraction frac3 = new Fraction(3,4);
        Console.WriteLine(frac3.GetFraction());
        Console.WriteLine(frac3.GetDecimal());

    }
}