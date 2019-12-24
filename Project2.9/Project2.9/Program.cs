using System;

namespace Project2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            int s = (a + b) / 2;

            Console.WriteLine("average:" + s);
        }
    }
}
