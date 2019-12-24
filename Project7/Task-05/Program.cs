using System;

namespace Task_05
{
    class Program
    { //Определите количество столбцов и количество строк массива, в которых не содержится ни одного отрицательного 
      //элемента. Выведите на экран найденные значения

        static void Main(string[] args)
        {
            int b = 10,a=10;
            int[,] arr = new int[b,a];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr[i,j] = new Random().Next(-20,100);
                    Console.Write(arr[i,j] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int aCount = 0;
            int aNegative = 0;
            for (int j = 0; j < a; j++)
            {
                aNegative = 0;
                for (int i = 0; i < b; i++)
                {
                    if (arr[i, j] < 0)
                    aNegative++;
                }
                if (aNegative > 0)
                    aCount++;
            }
            if (aCount < 1)
            {
                Console.WriteLine("Columns without negative elements are missing!\n");
            }
            else
            {
                Console.WriteLine("Number of columns without negative elements: " + (a - aCount));
            }
            Console.WriteLine();
            int bCount = 0;
            int bNegative = 0;
            for (int i = 0; i < b; i++)
            {
                bNegative = 0;
                for (int j = 0; j < a; j++)
                {
                    if (arr[i, j] < 0)
                        bNegative++;
                }
                if (bNegative > 0)
                    bCount++;
            }
            if (bCount < 1)
            {
                Console.WriteLine("Rows without negative elements are missing!\n");
            }
            else
            {
                Console.WriteLine("Number of rows without negative elements: " + (b - bCount));
            }
            Console.WriteLine();
            
        }
    }
}
