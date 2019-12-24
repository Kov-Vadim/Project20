using System;

namespace Project2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            double b = Math.Pow(a, 2);
            Console.WriteLine("squared "+a+"=" +b);
        }
    }
}
