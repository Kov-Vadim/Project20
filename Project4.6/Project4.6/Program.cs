using System;

namespace Project4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = new Random().Next(1, 200);
            var b = new Random().Next(1, 6);
            Console.WriteLine(b);
            double c;
            if (b == 1)
            {
                c = a / 10;
                Console.WriteLine($"{a}дм={c}м");
            }
            else if (b == 2)
            {
                c = a * 1000;
                Console.WriteLine($"{a}км={c}м");
            }
            else if (b ==3)
            {
                c = a; 
                Console.WriteLine($"{a}м={c}м");
            }
            else if (b == 4)
            {
                c = a / 1000;
                Console.WriteLine($"{a}мм={c}м");
            }
            else
            {
                c = a / 100;
                Console.WriteLine($"{a}см={c}м");
            }
        }
    }
}
