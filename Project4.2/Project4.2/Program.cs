using System;

namespace Project4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Random().Next(-100, 100);
            var b = new Random().Next(-100, 100);
            var c = new Random().Next(-100, 100);
            Console.WriteLine($"a={a},b={b},c={c}");
            if (a>0 & b>0 & c>0)
            {
                Console.WriteLine("Все числа положительные");
            }
            else if (a > 0 & b > 0 & c <=0 | a <= 0 & b > 0 & c > 0 | a > 0 & b <= 0 & c > 0)
            {
                Console.WriteLine("2 числа положительные");
            }
            else if (a > 0 & b <= 0 & c <= 0 | a <= 0 & b > 0 & c <= 0 | a <= 0 & b <= 0 & c > 0)
            {
                Console.WriteLine("1 число положительное");
            }
            else {
                Console.WriteLine("Нет полжительных чисел");
            }
        }
    }
}
