using System;

namespace Task_06
{
    class Program
    { //Отсортируйте столбцы массива в порядке возрастания сумм их элементов
        static void Main(string[] args)
        {
            int b = 10, a = 10;
            int[] sum = new int[a];
            int[,] arr = new int[b, a];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr[i, j] = new Random().Next(-20, 100);
                    Console.Write(arr[i, j] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Sum:");
            for (int j = 0; j < a; j++)
            {
                sum[j] = 0;
                for (int i = 0; i < b; i++)
                {
                    sum[j] += arr[i, j];
                }
                Console.Write(sum[j]+"\t");
            }
            Console.WriteLine();
            Console.WriteLine("Sorted sum:");
            for (int j = 0; j < sum.Length; j++)
            {
                for (int i = j+1; i < sum.Length; i++)
                {
                    if (sum[j] > sum[i] )
                    {
                        int temp = sum[j];
                        sum[j] = sum[i];
                        sum[i] = temp;
                    }
                    
                }
                Console.Write(sum[j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
