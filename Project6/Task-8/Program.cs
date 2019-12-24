using System;

namespace Task_8
{
    class Program
    { //Дан массив целых чисел. Напечатать:а) все четные элементы;б) все элементы, оканчивающиеся нулем.

        static void Main(string[] args)
        {
            Console.Write("А)");
            {
                int b = 10;
                int[] a = new int[b];
                for (int i = 0; i < b; i++)
                {
                    a[i] = new Random().Next(100);
                    if (a[i]%2== 0)
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
                    a[i] = new Random().Next(100);
                    if (a[i] % 10 == 0)
                    {
                        Console.Write(a[i] + " ");
                    }
                }
            }
        }
    }
}
