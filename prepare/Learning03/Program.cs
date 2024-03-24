using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction quebrado = new Fraction();
        Fraction quebrado2 = new Fraction(5);
        Fraction quebrado3 = new Fraction(3, 4);
        Fraction quebrado4 = new Fraction(1, 3);
        Console.WriteLine(quebrado.GetFractionString());
        Console.WriteLine(quebrado.GetDecimalValue());
        Console.WriteLine(quebrado2.GetFractionString());
        Console.WriteLine(quebrado2.GetDecimalValue());
        Console.WriteLine(quebrado3.GetFractionString());
        Console.WriteLine(quebrado3.GetDecimalValue());
        Console.WriteLine(quebrado4.GetFractionString());
        Console.WriteLine(quebrado4.GetDecimalValue());
    }
}