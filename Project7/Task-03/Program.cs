using System;

namespace Task_03
{
    class Program
    { //Выясните есть ли одинаковые числа в массиве или же массив содержит только разные
        static void Main(string[] args)
        {
            bool c = false;
            int b = 10;
            int[] arr = new int[b];
            for (int i = 0; i < b; i++)
            {
                arr[i] = new Random().Next(20);
                Console.Write(arr[i] + " ");
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        c = true;
                        break;
                    }
                }
            }
            Console.WriteLine();
            if (c)
            {
                Console.WriteLine("Have the same numbers");
            }
            else
                Console.WriteLine("No identical numbers");
        }
    }
}
