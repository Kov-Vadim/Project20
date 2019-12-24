using System;

namespace Task_13
{
    class Program
    { //Определить сумму второго, четвертого, шестого и т. д. элементов массива.
        static void Main(string[] args)
        {
            int b = 20, sum = 0;
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = new Random().Next(100);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (int i = 1; i < b; i+=2)
            {
                    sum += a[i];
            }
            Console.WriteLine($"sum={sum}");
        }
    }
}
