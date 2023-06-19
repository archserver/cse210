using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine($"Fraction: {f1.GetFractionString()} Decimal: {f1.GetDecimalValue()}");
        Fraction f2 = new Fraction(5);
        Console.WriteLine($"Fraction: {f2.GetFractionString()} Decimal: {f2.GetDecimalValue()}");
        Fraction f3 = new Fraction(1,3);
        Console.WriteLine($"Fraction: {f3.GetFractionString()} Decimal: {f3.GetDecimalValue()}");
        Fraction f4 = new Fraction(375,12);
        Console.WriteLine($"Fraction: {f4.GetFractionString()} Decimal: {f4.GetDecimalValue()}");
        


    }
}