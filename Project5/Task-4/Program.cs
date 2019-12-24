using System;

namespace Task_4
{
    class Program
    { //Даны натуральное число n и вещественные числа Найти: а) максимальное из вещественных чисел; б) минимальное из 
      //вещественных чисел; в) максимальное и минимальное из вещественных чисел. Примечание В задаче (в) использовать 
      //только один оператор цикла​

        static void Main(string[] args)
        {
            var n = new Random().Next(20);
            double a,max=0,min=100;
            Console.WriteLine($"n={n}");
            for (int i = 1; i <= n; i++)
            {
                a = Convert.ToDouble(new Random().Next(100) / 10.0);
                Console.WriteLine($"a={a}");
                max = Math.Max(max,a);
                min = Math.Min(min, a);
            }
            
            Console.WriteLine($"max={max}");
            Console.WriteLine($"min={min}");
        }
    }
}
