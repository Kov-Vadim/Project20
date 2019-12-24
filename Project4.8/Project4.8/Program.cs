using System;

namespace Project4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Random().Next(20, 70);

            if (a % 10==1)
            {
                Console.WriteLine($"{a} год");
            }
            else if (a%10==2 | a % 10 == 3 | a % 10 == 4)
            {
                Console.WriteLine($"{a} года");
            }
            else 
            {
                Console.WriteLine($"{a} лет");
            }
        }
    }
}
