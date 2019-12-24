using System;

namespace Task_3
{
    class Program
    { //Используя датчик случайных чисел, заполнить массив из двадцати элементов неповторяющимися числами.
        static void Main(string[] args)
        {
            int b = 20;
            int[] a = new int[b];
            for (int i = 0; i < b;i++)
            {
                int rand = new Random().Next(21);
                    if (a[i] != rand)
                    {
                        a[i] = rand;
                        Console.Write(a[i] + " ");
                    }
            }
        }
    }
}
