using System;

namespace Task_11
{
    class Program
    { //*Пользователь вводит число. Определить сумму всех элементов массива, которые больше заданного пользователем 
      //числа, если такое есть
        static void Main(string[] args)
        {
            int b = 10, a = 10, sum = 0;
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
            Console.WriteLine("Enter value:");
            int c = Convert.ToByte(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (arr[i,j]>c)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine($"sum={sum}");
        }
    }
}
