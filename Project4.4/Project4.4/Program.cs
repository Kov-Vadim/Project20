using System;

namespace Project4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Random().Next(-100, 100);
            var b = new Random().Next(-100, 100);
            Console.WriteLine($"a1={a},b1={b}");
            if (a != b)
            {
                a = b = a+b;
                Console.WriteLine($"a2={a},b2={b}");
            }
            else 
            {
                a = b = 0;
                Console.WriteLine($"a2={a},b2={b}");
            }
        }
    }
}
