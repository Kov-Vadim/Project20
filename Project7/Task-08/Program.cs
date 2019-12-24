using System;

namespace Task_08
{
    class Program
    { //Заполните главные диагонали массива нулями
        static void Main(string[] args)
        {
            int b = 10, a = 10,c=a+1;
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
                    if (i == j)
                    {
                        arr[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < b; i++)
            {
                c-=2;
                for (int j = 0; j < a; j++)
                {
                    if (i+c == j)
                    {
                        arr[i, j] = 0;
                    }
                    Console.Write(arr[i, j] + "\t ");
                }
                Console.WriteLine();
            }
        }
    }
}
