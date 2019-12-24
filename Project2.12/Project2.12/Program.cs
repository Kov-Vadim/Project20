using System;

namespace Project2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a two - digit number:");
            byte abc = byte.Parse(Console.ReadLine());
            int a, b, c;
            a = abc / 100;
            b = (abc % 100) / 10;
            c = (abc % 10);

            Console.WriteLine((a * 10) + (b * 100) + c);
        }
    }
}
