using System;

namespace Task_6
{
    class Program
    { //Дан массив целых чисел. Выяснить:а) верно ли, что сумма элементов массива есть четное число;б) верно ли, 
      //что сумма квадратов элементов массива есть пятизначное число.

        static void Main(string[] args)
        {
            Console.Write("А)");
            {
                int b = 10, sum=0;
                int[] a = new int[b];
                for (int i = 0; i < b; i++)
                {
                    a[i] = new Random().Next(100);
                    Console.Write(a[i] + " ");
                    sum += a[i];
                }
                
                Console.WriteLine();
                Console.WriteLine($"sum={sum}");
                if (sum % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
            Console.WriteLine();
            Console.Write("Б)");
            {
                int b = 10, sum=0;
                int[] a = new int[b];
                for (int i = 0; i < b; i++)
                {
                    a[i] = new Random().Next(100);
                    Console.Write(a[i] + " ");
                    sum += (a[i] * a[i]);
                }
                
                Console.WriteLine();
                Console.WriteLine($"sum={sum}");
                if (sum >9999 & sum <100000)
                {
                    Console.WriteLine("Five-digit");
                }
                else
                {
                    Console.WriteLine("Not five-digit");
                }
            }
        }
    }
}
