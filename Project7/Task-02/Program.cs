using System;

namespace Task_02
{
    class Program
    { //С помощью генератора случайных значений создайте два массива. Выполните по отдельности сначала сложение, 
      //потом умножения массивов друг на друга. Выведете исходные массивы и результат вычислений на экран

        static void Main(string[] args)
        {
            Console.Write($"M1:");
            int b = 10,sum=0,d;
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = new Random().Next(100);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.Write($"M2:");
            int b1 = 10;
            int[] a1 = new int[b1];
            for (int i = 0; i < b1; i++)
            {
                a1[i] = new Random().Next(100);
                Console.Write(a1[i] + " ");
            }
            Console.WriteLine();
            Console.Write($"sum:");
            for (int i = 0; i < b; i++)
            {
                sum = a[i] + a1[i];
                Console.Write(sum + " ");
            }
            Console.WriteLine();
            Console.Write($"product: ");
            for (int i = 0; i < b; i++)
            {
                d = a[i] * a1[i];
                Console.Write(d + " ");
            }
            Console.WriteLine();
        }
    }
}
