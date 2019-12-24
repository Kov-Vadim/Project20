using System;

namespace Task_11
{
    class Program
    { //Дан массив. Найти:а) сумму элементов массива, значение которых не превышает 20;б) сумму элементов массива, 
      //больших числа a.

        static void Main(string[] args)
        {
            int b = 20,sumA=0,sumB=0,A= new Random().Next(100);
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = new Random().Next(100);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.Write("А)");
            for (int i = 0; i < b; i++)
            {
                if (a[i] <=20)
                {
                    sumA += a[i]; 
                }
                
            }
            Console.WriteLine($"sum={sumA}");
            Console.Write("Б)");
            Console.WriteLine($"A={A}");
            for (int i = 0; i < b; i++)
            {
                if (a[i] <=A)
                {
                    sumB += a[i];
                }
                
            }
            Console.WriteLine($"sum={sumB}");
            Console.WriteLine();
        }
    }
}
