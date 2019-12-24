using System;

namespace Project4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Random().Next(-100, 100);
            Console.WriteLine($"a={a}");
            if (a%2==0)
            {
                Console.WriteLine("Число четное");
            }
            else 
            {
                Console.WriteLine("Число нечетное");
            }
           
        }
    }
}
