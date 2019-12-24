using System;

namespace Project3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");
            byte R = byte.Parse(Console.ReadLine());
            Metod(R);
        }

        static void Metod(int R)
        {
            Console.WriteLine($"d={R * 2}");
        }
        static void Metod(double R)
        {
            Console.WriteLine($"d={R * 2}");
        }
        static void Metod(string R)
        {
            Console.WriteLine($"d={R} * 2");
        }
    }
}
