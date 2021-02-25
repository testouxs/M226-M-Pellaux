using System;

namespace ConsoleFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f0 = new Fraction();
            Fraction f1 = new Fraction(7);
            Fraction f2 = new Fraction(3, 6);
            Console.WriteLine("bonjour a tous");
            Console.WriteLine(f0);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
        }
    }
}
