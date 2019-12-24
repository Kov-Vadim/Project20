using System;

namespace Project4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Random().Next(-100,100);
            Console.WriteLine($"a1={a}");
            if (a > 0)
            {
                a++;
                Console.WriteLine($"a2={a}");
            }
            else if (a < 0)
            {
                a=a-2;
                Console.WriteLine($"a2={a}");
            }
            else 
            {
                a=10;
                Console.WriteLine($"a2={a}");
            }
        }
    }
}
