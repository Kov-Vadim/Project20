using System;

namespace Task_2
{
    class Program
    { //Заполнить массив из пятнадцати элементов случайным образом:а) вещественными значениями, лежащими в диапазоне 
      //от 0 до 1;б) вещественными значениями х (22 х < 23);в) вещественными значениями х (0 х < 10);г) 
      //вещественными значениями х (–50 х < 50);д) целыми значениями, лежащими в диапазоне от 0 до 10 включительно.

        static void Main(string[] args)
        {
            Console.Write("А)");
            {
                int b = 10;
                int[] a = new int[b];
                for (int i = 0; i < b; i++)
                {
                    a[i] = new Random().Next(0, 2);
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
                    int x = new Random().Next(-100,100);
                    if (22 * x < 23)
                    {
                        a[i] = x;
                        Console.Write(a[i] + " ");
                    }
                }
            }
            Console.WriteLine();
            Console.Write("В)");
            {
                int b = 10;
                int[] a = new int[b];
                for (int i = 0; i < b; i++)
                {
                    int x = new Random().Next(-100, 100);
                    if (0 * x < 10)
                    {
                        a[i] = x;
                        Console.Write(a[i] + " ");
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Г)");
            {
                int b = 10;
                int[] a = new int[b];
                for (int i = 0; i < b; i++)
                {
                    int x = new Random().Next(-100, 100);
                    if (-50 * x < 50)
                    {
                        a[i] = x;
                        Console.Write(a[i] + " ");
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Д)");
            {
                int b = 10;
                int[] a = new int[b];
                for (int i = 0; i < b; i++)
                {
                    a[i] = new Random().Next(0, 11);
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
