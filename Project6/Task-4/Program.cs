using System;

namespace Task_4
{
    class Program
    { //Дан массив. Все его элементы:а) увеличить в 2 раза;б) уменьшить на число А;в) разделить на первый элемент.
        static void Main(string[] args)
        {
            Console.Write("А)");
            {
                int b = 10;
                int[] a = new int[b];
                for (int i = 0; i < b; i++)
                {
                    a[i] = new Random().Next(100);
                    a[i] += 2;
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Б)");
            {
                int b = 10;
                int[] a = new int[b];
                for (int i = 0; i < b; i++)
                {
                    int A = new Random().Next(100);
                    a[i] = new Random().Next(100);
                    a[i] += A;
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
            Console.Write("В)");
            {
                int b = 10;
                int[] a = new int[b];
                for (int i = 0; i < b; i++)
                {
                    a[i] = new Random().Next(100);
                    a[i] /= a[0] ;
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
