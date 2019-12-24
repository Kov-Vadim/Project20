using System;

namespace Task_15
{
    class Program
    { //Рост каждого из 22 учеников класса представлен в виде массива. Определить количество учеников, рост которых 
      //не превышает значения r.

        static void Main(string[] args)
        {
            int b = 20, r = new Random().Next(160, 195);
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = new Random().Next(140, 195);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"r={r}");
            for (int i = 0; i < b; i++)
            {
                if (a[i] <= r)
                {
                    Console.Write(a[i] + " ");
                }
            }
        }
    }
}
