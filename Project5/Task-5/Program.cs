using System;

namespace Task_5
{
    class Program
    { //Даны два целых числа A и B (A < B). Найти сумму и произведение всех целых чисел от A до B включительно.​
        static void Main(string[] args)
        {
            double a, b;
            a = new Random().Next(1,20);
            b = new Random().Next(1,20);
            while (a >= b )
            {
                a = new Random().Next(1,20);
                b = new Random().Next(1,20);
            } 
            Console.WriteLine($"a={a},b={b}");
            double sum = 0, product = 1;
            for (double i = a; i <= b; i++)
            {
                sum += i;
                product = product * i;
            }
            Console.WriteLine($"sum={sum},product={product}");
        }
    }
}
