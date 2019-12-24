using System;

namespace Projekt3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount(UAH):");
            byte uah = byte.Parse(Console.ReadLine());
            double r = 2.62, d = 0.04, e = 0.037;

            Rub(r, uah);
            Dollar(d, uah);
            Euro(e, uah);
        }

        static void Rub(double r,double uah)
        {
            Console.WriteLine($"Rub={uah * r}"); 
        }
        static void Dollar(double d,double uah)
        {
            Console.WriteLine($"Dollar={uah * d}");
        }
        static void Euro(double e,double uah)
        {
            Console.WriteLine($"Euro={uah * e}");
        }
        
        
    }
}
