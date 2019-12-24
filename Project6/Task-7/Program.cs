using System;

namespace Task_7
{
    class Program
    { //Дан массив. Напечатать:а) все неотрицательные элементы;б) все элементы, не превышающие число 100.

        static void Main(string[] args)
        {
            Console.Write("А)");
            {
                int b = 10;
                int[] a = new int[b];
                for (int i = 0; i < b; i++)
                {
                    a[i] = new Random().Next(-100, 200);
                    if (a[i] >= 0)
                    {
                        Console.Write(a[i] + " ");
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Б)");
            {
                int b = 10;
                int[] a = new int[b];
                for (int i = 0; i < b; i++)
                {
                    a[i] = new Random().Next(-100, 200);
                    if (a[i] <= 100)
                    {
                        Console.Write(a[i] + " ");
                    }
                }
            }
        }
    }
}
