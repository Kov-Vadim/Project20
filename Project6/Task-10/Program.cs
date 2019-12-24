using System;

namespace Task_10
{
    class Program
    { //Дан массив. Вывести на экран сначала его элементы, стоящие на четных местах, затем — на нечетных.
        static void Main(string[] args)
        {
            int b = 10;
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = new Random().Next(100);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (int i = 1; i < b; i+=2)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < b; i+=2)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
