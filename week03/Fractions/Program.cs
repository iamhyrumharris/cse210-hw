using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFracNum());
        Console.WriteLine(fraction.GetDecNum());

        Fraction fraction1 = new Fraction(5,2);
        Console.WriteLine(fraction1.GetFracNum());
        Console.WriteLine(fraction1.GetDecNum());
        
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFracNum());
        Console.WriteLine(fraction2.GetDecNum());
    }
}