using System;

namespace Task_10
{
    class Program
    { //Поменять максимальный и минимальный элемент массива местами
        static void Main(string[] args)
        {
            int b = 10, a = 10;
            int[,] arr = new int[b, a];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr[i, j] = new Random().Next(10);
                    Console.Write(arr[i, j] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int max = arr[0, 0], min = arr[0, 0];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                    }
                }
            }
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (max == arr[i, j])
                    {
                        arr[i, j] = min;
                    }
                    else if (min== arr[i, j])
                    {
                        arr[i, j]=max;
                    }
                    Console.Write(arr[i, j] + "\t ");
                }
                Console.WriteLine();
            }
        }
    }
}
