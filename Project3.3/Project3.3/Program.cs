using System;

namespace Project3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the number:");
            byte a = byte.Parse(Console.ReadLine());
            Metod(a);
        }

        static void Metod(int a)
        {
            Console.WriteLine($"P={a*4}");
        }
        static void Metod(double a)
        {
            Console.WriteLine($"P={a * 4}");
        }
        static void Metod(string a)
        {
            Console.WriteLine($"P={a} * 4");
        }
    }
}
