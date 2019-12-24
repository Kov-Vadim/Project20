using System;

namespace Task_03
{
    class Program
    { //Преобразовать строки двумерного массива в столбцы. Например было: 
      //11	22
      //33	44
      //55	66
      //77	88

      //стало:
      //11	33	55	77
      //22	44	66	88
        static void Main(string[] args)
        {
            int b = 10, a = 10;
            int[,] arr1 = new int[a,b];
            int[,] arr2 = new int[a, b];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr1[i, j] = new Random().Next(100);
                    Console.Write(arr1[i, j] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr2[i, j] = arr1[j,i];
                    Console.Write(arr2[i, j] + "\t ");
                }
                Console.WriteLine();
            }
        }
    }
}
