using System;

namespace Task_14
{
    class Program
    { //Дан массив. Определить количество неотрицательных элементов.
        static void Main(string[] args)
        {
            int b = 20, sum = 0;
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = new Random().Next(-100,100);;
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < b; i++)
            {
                if (a[i] >= 0)
                {
                    sum++;
                }
            }
            Console.WriteLine($"quantity:{sum}");
        }
    }
}
