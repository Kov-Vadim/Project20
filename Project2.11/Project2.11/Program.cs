using System;

namespace Project2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a two - digit number:");
            byte abc = byte.Parse(Console.ReadLine());
            int a, b,c;
            a = abc / 100;
            b = (abc%100)/10;
            c = (abc % 10);

            Console.WriteLine((c*100)+(b*10)+a);
        }
    }
}
