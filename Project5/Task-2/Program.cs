using System;

namespace Task_2
{
    class Program
    { //Найти сумму целых положительных чисел из промежутка от a до b, кратных четырем.
        static void Main(string[] args)
        {
            int sum = 0;
            var a = new Random().Next(0, 100);
            var b = new Random().Next(0, 100);
            Console.WriteLine($"a={a},b={b}");
            for (int i = 0;i<=100; i++)
            {
                if (a > b)
                {
                    if (i <= a & i >= b & i % 4 == 0)
                    {
                        sum += i;
                    }
                }
                else if (a < b)
                {
                    if (i >= a & i <= b & i % 4 == 0)
                    {
                        sum += i;
                    }
                }
            }
            Console.WriteLine($"sum={sum}"); 
        }
    }
}
