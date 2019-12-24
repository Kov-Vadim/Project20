using System;

namespace Task_03
{
    class Program
    { //Дан квадратный массив. Поменяйте местами элементы, стоящие на главной и побочной диагонали, при этом каждый 
      //элемент должен остаться в том же столбце (то есть в каждом столбце нужно поменять местами элемент на главной 
      //диагонали и на побочной диагонали).
        static void Main(string[] args)
        {
            int b = 10, a = 10, c = a + 1;
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
            int s = 0;
            for (int i = 0; i < b; i++)
            {
                c -= 2;
                for (int j = 0; j < a; j++)
                {
                    if (i == j )
                    {
                        s = arr[i,j];
                        arr[i, j] = arr[i,j+c];
                    }
                    if (i + c == j)
                    {
                        arr[i, j] = s;
                    }
                    Console.Write(arr[i, j] + "\t ");
                }
                Console.WriteLine();
            }
        }
    }
}
