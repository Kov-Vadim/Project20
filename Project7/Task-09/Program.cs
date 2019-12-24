using System;

namespace Task_09
{
    class Program
    { //Выведете на экран номера тех ячеек массива, в которых находятся отрицательные числа
        static void Main(string[] args)
        {
            int b = 10, a = 10;
            int[,] arr = new int[b, a];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr[i, j] = new Random().Next(-50,100);
                    Console.Write(arr[i, j] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (arr[i, j] < 0)
                    {
                        Console.Write($"[{i},{j}]\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
