using System;

namespace Task_9
{
    class Program
    { //Дан массив. Вывести на экран сначала его неотрицательные элементы, затем отрицательные.

        static void Main(string[] args)
        {
            int b = 10;
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = new Random().Next(-100,100);
            }
            for (int i = 0; i < b; i++)
            {
                if (a[i] > 0)
                {
                    Console.Write(" "+a[i] + " ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < b; i++)
            {
                if (a[i] < 0)
                {
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
