using System;

namespace Task_12
{
    class Program
    { //Дан массив целых чисел. Найти:а) сумму нечетных элементов;б) сумму элементов, кратных заданному числу C;в) 
      //сумму элементов массива, кратных A или B.
        static void Main(string[] args)
        {
            int b = 10, sumA = 0, sumB = 0,sumC=0, A = new Random().Next(100), B = new Random().Next(100),C ;
            int[] a = new int[b];
            for (int i = 0; i < b; i++)
            {
                a[i] = new Random().Next(100);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.Write("А)");
            for (int i = 0; i < b; i++)
            {
                if (a[i]%2!= 0)
                {
                    sumA += a[i];
                }

            }
            Console.WriteLine($"sum={sumA}");
            Console.Write("Б)");
            Console.Write("Insert the number:");
            C = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"C={C}");
            for (int i = 0; i < b; i++)
            {
                if (a[i]%C!= 0)
                {
                    sumB += a[i];
                }

            }
            Console.WriteLine($"sum={sumB}");
            Console.Write("В)");
            Console.WriteLine($"A={A},B={B}");
            for (int i = 0; i < b; i++)
            {
                if (a[i] % A != 0 | a[i]%B!=0)
                {
                    sumC += a[i];
                }

            }
            Console.WriteLine($"sum={sumC}");
            Console.WriteLine();
        }
    }
}
