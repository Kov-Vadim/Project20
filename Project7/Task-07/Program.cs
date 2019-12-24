using System;

namespace Task_07
{
    class Program
    { //Просуммируйте все элементы двумерного массива
        static void Main(string[] args)
        {
            int b = 10, a = 10,sum=0;
            int[,] arr = new int[b, a];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr[i, j] = new Random().Next(100);
                    Console.Write(arr[i, j] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine($"sum={sum}");
        }
    }
}
