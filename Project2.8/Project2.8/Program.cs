using System;

namespace Project2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a two - digit number:");
            byte ab = byte.Parse(Console.ReadLine());
            int a, b,s,c;
            a = ab / 10;
            b = (ab % 10);
            s = a + b;
            c = a * b;

            Console.WriteLine(" dozens:" + a + "\n units:" + b + "\n scrip:" + s + "\n product:" + c);
        }
    }
}
