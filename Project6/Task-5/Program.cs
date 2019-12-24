using System;

namespace Task_5
{
    class Program
    { //В массиве хранятся сведения о стоимости 12 различных предметов. Определить общую стоимость всех предметов.
        static void Main(string[] args)
        {
            int b = 12,sum;
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = new Random().Next(100);
                Console.Write(a[i] + " ");
            }
            sum = a[0] + a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10] + a[11];
            Console.WriteLine();
            Console.WriteLine($"sum={sum}");
        }
    }
}
