using System;

namespace Task_8
{
    class Program
    { //Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; при этом каждое 
      //число должно выводиться столько раз, каково его значение (например, число 3 выводится 3 раза).
        static void Main(string[] args)
        {
            int a, b;
            a = new Random().Next(0, 20);
            b = new Random().Next(0, 20);
            while (a > b)
            {
                a = new Random().Next(0, 20);
                b = new Random().Next(0, 20);
            }
            Console.WriteLine($"a={a},b={b}");
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine($"i={i}");
                }

            }
        }
    }
}
