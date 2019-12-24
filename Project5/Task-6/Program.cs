using System;

namespace Task_6
{
    class Program
    { //Даны два целых числа A и B (A < B). Вывести в порядке возрастания все целые числа, расположенные между A и B 
      //(включая сами числа A и B),  а также количество N этих чисел.​

        static void Main(string[] args)
        {
            double a, b;
            a = new Random().Next(1,20);
            b = new Random().Next(1,20);
            while (a >= b)
            {
                a = new Random().Next(1,20);
                b = new Random().Next(1,20);
            }
            Console.WriteLine($"a={a},b={b}");
           
            for (double i = a; i <= b; i++)
            {
                Console.WriteLine($"i={i}");
                
            }
            double N=0;
            for (double i = a; i <= b; i++)
            {
                N++;
            }
            Console.WriteLine($"N={N}");
        }
    }
}
